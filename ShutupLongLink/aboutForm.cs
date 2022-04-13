using System;
using System.Windows.Forms;

namespace ShutupLongLink
{
    public partial class aboutForm : Form
    {
        public aboutForm()
        {
            InitializeComponent();

            #region Get The Product Version 1.0.0.0

            lblVersion.Text = lblVersion.Text + " " + Application.ProductVersion + " ( .Net Frame 4.7.2 )";
            
            #endregion
        }


        #region Close Event
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Facebook Pic Event "Go To FB Page"
        private void picBxFacebook_Click(object sender, EventArgs e)
        {
            StartURLInBrowser.Url = "https://www.facebook.com/7Kingdomsar";
            StartURLInBrowser.StartDefualtBrowser();
        }
        #endregion

        #region Messanger Pic Event "Go To Messanger Page"
        private void picBxMessenger_Click(object sender, EventArgs e)
        {
            StartURLInBrowser.Url = "https://m.me/bassuny3003";
            StartURLInBrowser.StartDefualtBrowser();

        }
        #endregion

        #region Telegram Pic Event "Go To Telegram Channel"
        private void picBxTelegram_Click(object sender, EventArgs e)
        {
            StartURLInBrowser.Url = "https://t.me/techkingdomchannel";
            StartURLInBrowser.StartDefualtBrowser();

        }
        #endregion

        #region Youtube Pic Event "Go To Youtube Channel"
        private void picBxYoutube_Click(object sender, EventArgs e)
        {
            StartURLInBrowser.Url = "https://bit.ly/2JfJlpi";
            StartURLInBrowser.StartDefualtBrowser();

        }
        #endregion

        #region PayPal Me Pic Event "Go To PayPalMe Website"
        private void picBxPayPalMe_Click(object sender, EventArgs e)
        {
            StartURLInBrowser.Url = "https://www.paypal.com/paypalme/MBassuny/1";
            StartURLInBrowser.StartDefualtBrowser();
        } 
        #endregion
    }
}
