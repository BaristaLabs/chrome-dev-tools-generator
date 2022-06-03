namespace BaristaLabs.ChromeDevTools
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Net.Http;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Represents and manages a chrome process instance
    /// </summary>
    public sealed class Chrome : IDisposable
    {
        private readonly int m_remoteDebuggingPort;
        private DirectoryInfo m_userDirectory;

        internal Chrome(Process chromeProcess, DirectoryInfo userDirectory, int remoteDebuggingPort)
        {
            Process = chromeProcess ?? throw new ArgumentNullException(nameof(chromeProcess));
            m_userDirectory = userDirectory ?? throw new ArgumentNullException(nameof(userDirectory));
            m_remoteDebuggingPort = remoteDebuggingPort;
        }

        /// <summary>
        /// Gets the Process object for the Chrome Instance
        /// </summary>
        public Process Process { get; private set; }

        public async Task<ChromeVersion> GetChromeVersion()
        {
            ChromeVersion version;
            using (var chromeDebuggerClient = GetDebuggerClient())
            {
                var chromeVersionResponseBody = await chromeDebuggerClient.GetStringAsync("/json/version");
                version = JsonConvert.DeserializeObject<ChromeVersion>(chromeVersionResponseBody);
            }

            return version;
        }

        private HttpClient GetDebuggerClient()
        {
            var chromeHttpClient = new HttpClient()
            {
                BaseAddress = new Uri($"http://localhost:{m_remoteDebuggingPort}")
            };

            return chromeHttpClient;
        }

        #region IDisposable Support
        void Dispose(bool disposing)
        {
            if (disposing)
            {
                //Kill the chrome process.
                if (Process != null)
                {
                    if (Process.HasExited == false)
                        Process.WaitForExit(5000);

                    if (Process.HasExited == false)
                        Process.Kill();

                    Process.Dispose();
                    Process = null;
                }

                //Clean up the target user directory.
                if (m_userDirectory != null)
                {
                    //for (int i = 0; i < 10; i++)
                    //{
                    //    if (m_userDirectory.Exists == false)
                    //        continue;

                    //    try
                    //    {
                    //        Thread.Sleep(500);
                    //        m_userDirectory.Delete(true);
                    //    }
                    //    catch
                    //    {
                    //        //Do Nothing.
                    //    }
                    //}

                    //if (m_userDirectory.Exists)
                    //    throw new InvalidOperationException($"Unable to delete the user directory at {m_userDirectory.FullName} after 10 tries.");

                    m_userDirectory = null;
                }
            }
        }

        public void Dispose()
        {
            Dispose(true);
        }
        #endregion

        /// <summary>
        /// Creates a new chrome instance
        /// </summary>
        /// <param name="remoteDebuggingPort"></param>
        /// <returns></returns>
        public static Chrome OpenChrome(int remoteDebuggingPort = 9222)
        {
            string path = Path.GetRandomFileName();
            var directoryInfo = Directory.CreateDirectory(Path.Combine(Path.GetTempPath(), path));
            var remoteDebuggingArg = $"--remote-debugging-port={remoteDebuggingPort}";
            var userDirectoryArg = $"--user-data-dir=\"{directoryInfo.FullName}\"";
            var chromeProcessArgs = $"{remoteDebuggingArg} {userDirectoryArg} --bwsi --no-first-run";

            Process chromeProcess;
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                String programFiles = RuntimeInformation.OSArchitecture == Architecture.X86
                    ? "Program Files (x86)"
                    : "Program Files";
                chromeProcess = Process.Start(new ProcessStartInfo($"C:\\{programFiles}\\Google\\Chrome\\Application\\chrome.exe", chromeProcessArgs) { CreateNoWindow = true });
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
            {
                chromeProcess = Process.Start("google-chrome", chromeProcessArgs);
            }
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
            {
                chromeProcess = Process.Start("/Applications/Google Chrome.app/Contents/MacOS/Google Chrome", chromeProcessArgs);
            }
            else
            {
                throw new InvalidOperationException("Unknown or unsupported platform.");
            }

            return new Chrome(chromeProcess, directoryInfo, remoteDebuggingPort);
        }

        /// <summary>
        /// Retrieves the browser protocol pdl for the specified chrome version.
        /// </summary>
        /// <remarks>
        /// Um, yeah. See https://github.com/cyrus-and/chrome-remote-interface/issues/10#issuecomment-146032907
        /// </remarks>
        /// <returns></returns>
        public static async Task<string> GetBrowserProtocolForChromeVersion(ChromeVersion chromeVersion)
        {
            var browserProtocolUrl = $"https://chromium.googlesource.com/chromium/src/+/{chromeVersion.WebKitVersionHash}/third_party/blink/public/devtools_protocol/browser_protocol.pdl?format=TEXT";

            using (var browserProtocolClient = new HttpClient())
            {
                var browserProtocol64 = await browserProtocolClient.GetStringAsync(browserProtocolUrl);
                return Encoding.UTF8.GetString(Convert.FromBase64String(browserProtocol64));
            }
        }

        /// <summary>
        /// Retrieves the javascript protocol pdl for the specified chrome version.
        /// </summary>
        public static async Task<string> GetJavaScriptProtocolForChromeVersion(ChromeVersion chromeVersion)
        {
            var jsProtocolUrl = $"https://chromium.googlesource.com/v8/v8/+/{chromeVersion.V8VersionNumber}/include/js_protocol.pdl?format=TEXT";
            using (var jsProtocolClient = new HttpClient())
            {
                var jsProtocol64 = await jsProtocolClient.GetStringAsync(jsProtocolUrl);
                return Encoding.UTF8.GetString(Convert.FromBase64String(jsProtocol64));
            }
        }

        /// <summary>
        /// Retrieves the python script that converts a pdl into json for the specified chrome version.
        /// </summary>
        /// <param name="chromeVersion"></param>
        /// <returns></returns>
        public static async Task<string> GetInspectorProtocolConverterPythonScript(ChromeVersion chromeVersion)
        {
            var protocolScriptUrl = $"https://chromium.googlesource.com/chromium/src/+/{chromeVersion.WebKitVersionHash}/third_party/inspector_protocol/pdl.py?format=TEXT";
            using (var jsProtocolClient = new HttpClient())
            {
                var script64 = await jsProtocolClient.GetStringAsync(protocolScriptUrl);
                return Encoding.UTF8.GetString(Convert.FromBase64String(script64));
            }
        }

        /// <summary>
        /// Merges a browserProtocol and jsProtocol into a single protocol definition.
        /// </summary>
        /// <param name="browserProtocol"></param>
        /// <param name="jsProtocol"></param>
        /// <returns></returns>
        public static JObject MergeJavaScriptProtocolDefinitions(JObject browserProtocol, JObject jsProtocol)
        {
            //Merge the 2 protocols together.
            if (jsProtocol["version"]["majorVersion"] != browserProtocol["version"]["majorVersion"] ||
                jsProtocol["version"]["minorVersion"] != browserProtocol["version"]["minorVersion"])
            {
                throw new InvalidOperationException("Protocol mismatch -- The WebKit and V8 protocol versions should match.");
            }

            var result = browserProtocol.DeepClone() as JObject;
            foreach (var domain in jsProtocol["domains"])
            {
                JArray jDomains = (JArray)result["domains"];
                jDomains.Add(domain);
            }

            return result;
        }
    }
}
