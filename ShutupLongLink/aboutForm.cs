using System;
using System.Windows.Forms;

namespace ShutupLongLink
{
    public partial class aboutForm : Form
    {
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
            StartURLInBrowser.Url = "https://www.facebook.com/7Kingdomsar";
            StartURLInBrowser.launchDefualtBrowser();
        }

        private void picBxMessenger_Click(object sender, EventArgs e)
        {
            StartURLInBrowser.Url = "https://m.me/bassuny3003";
            StartURLInBrowser.launchDefualtBrowser();

        }

        private void picBxTelegram_Click(object sender, EventArgs e)
        {
            StartURLInBrowser.Url = "https://t.me/techkingdomchannel";
            StartURLInBrowser.launchDefualtBrowser();

        }

        private void picBxYoutube_Click(object sender, EventArgs e)
        {
            StartURLInBrowser.Url = "https://bit.ly/2JfJlpi";
            StartURLInBrowser.launchDefualtBrowser();

        }

        private void picBxPayPalMe_Click(object sender, EventArgs e)
        {
            StartURLInBrowser.Url = "https://www.paypal.com/paypalme/MBassuny/1";
            StartURLInBrowser.launchDefualtBrowser();
        }
    }
}
