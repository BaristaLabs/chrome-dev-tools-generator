namespace BaristaLabs.ChromeDevTools
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Runtime.InteropServices;

    public static class ChromeFactory
    {
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
                chromeProcess = Process.Start(new ProcessStartInfo(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", chromeProcessArgs) { CreateNoWindow = true });
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
    }
}
