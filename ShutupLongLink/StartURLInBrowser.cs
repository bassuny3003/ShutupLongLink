using Microsoft.Win32;
using System.Diagnostics;

namespace ShutupLongLink
{
    public static class StartURLInBrowser
    {
        public static string Url { get; set; }


        public static void StartLink()
        {
            ProcessStartInfo processStartInfo = new ProcessStartInfo("cmd", "/C start " + Url)
            {
                RedirectStandardError = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true
            };

            Process process = new Process();

            process.StartInfo = processStartInfo;
            process.Start();
        }

        public static void launchDefualtBrowser()
        {
            string browserName = "iexplore.exe";
            using (RegistryKey userChoiceKey = Registry.CurrentUser.OpenSubKey(@"Software\Microsoft\Windows\Shell\Associations\UrlAssociations\http\UserChoice"))
            {
                if (userChoiceKey != null)
                {
                    object progIdValue = userChoiceKey.GetValue("Progid");
                    if (progIdValue != null)
                    {
                        if (progIdValue.ToString().ToLower().Contains("chrome"))
                            browserName = "chrome.exe";
                        else if (progIdValue.ToString().ToLower().Contains("firefox"))
                            browserName = "firefox.exe";
                        else if (progIdValue.ToString().ToLower().Contains("safari"))
                            browserName = "safari.exe";
                        else if (progIdValue.ToString().ToLower().Contains("opera"))
                            browserName = "opera.exe";
                    }
                }
            }

            Process.Start(browserName, Url);
        }
    }
}
