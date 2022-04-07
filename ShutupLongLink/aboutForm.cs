using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ShutupLongLink
{
    public partial class aboutForm : Form
    {
        public void launchBrowser(string url)
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

            Process.Start(browserName, url);
        }



        public aboutForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void picBxFacebook_Click(object sender, EventArgs e)
        {
            launchBrowser("https://www.facebook.com/7Kingdomsar");

        }

        private void picBxMessenger_Click(object sender, EventArgs e)
        {
            launchBrowser("https://m.me/bassuny3003");

        }

        private void picBxTelegram_Click(object sender, EventArgs e)
        {
            launchBrowser("https://t.me/techkingdomchannel");

        }

        private void picBxYoutube_Click(object sender, EventArgs e)
        {
            launchBrowser("https://bit.ly/2JfJlpi");

        }
    }
}
