namespace BaristaLabs.ChromeDevTools
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Net.Http;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public sealed class Chrome : IDisposable
    {
        private Process m_chromeProcess;
        private int m_remoteDebuggingPort;
        private DirectoryInfo m_userDirectory;

        internal Chrome(Process chromeProcess, DirectoryInfo userDirectory, int remoteDebuggingPort)
        {
            m_chromeProcess = chromeProcess ?? throw new ArgumentNullException(nameof(chromeProcess));
            m_userDirectory = userDirectory ?? throw new ArgumentNullException(nameof(userDirectory));
            m_remoteDebuggingPort = remoteDebuggingPort;
        }

        /// <summary>
        /// Gets the Process object for the Chrome Instance
        /// </summary>
        public Process Process
        {
            get { return m_chromeProcess; }
        }

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

        /// <summary>
        /// Retrieves a merged protocol version for the current chrome instance.
        /// </summary>
        /// <remarks>
        /// Um, yeah. See https://github.com/cyrus-and/chrome-remote-interface/issues/10#issuecomment-146032907
        /// </remarks>
        /// <returns></returns>
        public async Task<JObject> GetProtocolDefinitionForCurrentChromeVersion()
        {
            var currentVersion = await GetChromeVersion();

            //Get the webkit version hash.
            var webkitVersionRegex = new Regex(@"\s\(@(\b[0-9a-f]{5,40}\b)");
            var webkitVersionMatch = webkitVersionRegex.Match(currentVersion.WebKitVersion);
            if (webkitVersionMatch.Success == false || webkitVersionMatch.Groups.Count != 2)
                throw new InvalidOperationException($"Unable to determine webkit version hash from webkit version string ({currentVersion.WebKitVersion})");

            var webkitVersionHash = webkitVersionMatch.Groups[1].Value;

            //Get the v8 version
            var v8VersionRegex = new Regex(@"^(\d+)\.(\d+)\.(\d+)(\.\d+.*)?");
            var v8VersionMatch = v8VersionRegex.Match(currentVersion.V8Version);
            if (v8VersionMatch.Success == false || v8VersionMatch.Groups.Count < 4)
                throw new InvalidOperationException($"Unable to determine v8 version number from v8 version string ({currentVersion.V8Version})");

            var v8Version = $"{v8VersionMatch.Groups[1].Value}.{v8VersionMatch.Groups[2].Value}.{v8VersionMatch.Groups[3].Value}";

            var browserProtocolUrl = $"https://chromium.googlesource.com/chromium/src/+/{webkitVersionHash}/third_party/WebKit/Source/core/inspector/browser_protocol.json?format=TEXT";
            var jsProtocolUrl = $"https://chromium.googlesource.com/v8/v8/+/{v8Version}/src/inspector/js_protocol.json?format=TEXT";

            JObject jBrowserProtocol, jJsProtocol;

            using (var browserProtocolClient = new HttpClient())
            {
                var browserProtocol64 = await browserProtocolClient.GetStringAsync(browserProtocolUrl);
                var browserProtocolJson = Encoding.UTF8.GetString(Convert.FromBase64String(browserProtocol64));
                jBrowserProtocol = JObject.Parse(browserProtocolJson);
            }

            using (var jsProtocolClient = new HttpClient())
            {
                var jsProtocol64 = await jsProtocolClient.GetStringAsync(jsProtocolUrl);
                var jsProtocolJson = Encoding.UTF8.GetString(Convert.FromBase64String(jsProtocol64));
                jJsProtocol = JObject.Parse(jsProtocolJson);
            }

            //Merge the 2 protocols together.
            if (jJsProtocol["version"]["majorVersion"] != jBrowserProtocol["version"]["majorVersion"] ||
                jJsProtocol["version"]["minorVersion"] != jBrowserProtocol["version"]["minorVersion"])
            {
                throw new InvalidOperationException("Protocol mismatch -- The WebKit and V8 protocol versions should match.");
            }

            foreach(var domain in jJsProtocol["domains"])
            {
                JArray jDomains = (JArray)jBrowserProtocol["domains"];
                jDomains.Add(domain);
            }

            return jBrowserProtocol;
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
                if (m_chromeProcess != null)
                {
                    if (m_chromeProcess.HasExited == false)
                        m_chromeProcess.WaitForExit(5000);

                    if (m_chromeProcess.HasExited == false)
                        m_chromeProcess.Kill();

                    m_chromeProcess.Dispose();
                    m_chromeProcess = null;
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


    }
}
