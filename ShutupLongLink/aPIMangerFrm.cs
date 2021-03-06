using System;
using System.Windows.Forms;

namespace ShutupLongLink
{
    public partial class aPIMangerFrm : Form
    {
        public aPIMangerFrm()
        {
            InitializeComponent();

            #region Get All API Keys From Settings

            txtBxAdfly.Text = Properties.Settings.Default.UserAdflyAPIKey;
            txtBxAdflyUID.Text = Properties.Settings.Default.UserAdflyUID;

            txtBxR7URL.Text = Properties.Settings.Default.UserR7APIKey;

            txtBxShortest.Text = Properties.Settings.Default.UserShortestAPIKey;

            txtBxRebrandly.Text = Properties.Settings.Default.UserRebrandlyAPIKey;

            txtBxBitly.Text = Properties.Settings.Default.UserbitlyAPIKey;


            #endregion
        }

        #region Close API Manger Form

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion

        #region Save New API Keys Button 
        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserAdflyAPIKey = txtBxAdfly.Text;
            Properties.Settings.Default.UserAdflyUID = txtBxAdflyUID.Text;

            Properties.Settings.Default.UserR7APIKey = txtBxR7URL.Text;

            Properties.Settings.Default.UserShortestAPIKey = txtBxShortest.Text;

            Properties.Settings.Default.UserRebrandlyAPIKey = txtBxRebrandly.Text;

            Properties.Settings.Default.UserbitlyAPIKey = txtBxBitly.Text;

            Properties.Settings.Default.Save();

            Close();

        }

        #endregion

        #region Load Default API Keys Button

        private void btnLoadDefault_Click(object sender, EventArgs e)
        {
            txtBxAdfly.Text = "4035c8e1d3931ac1fec5f8d1cec122c1";
            txtBxAdflyUID.Text = "1503418";
            txtBxShortest.Text = "b38880d274a8bd8e710bf1c47369242b";
            txtBxR7URL.Text = "81ec9a87936f0b502f75cb6df8e71512aacddd6e";
            txtBxRebrandly.Text = "5d4bbf600d064db3a3ccb0e76e9e3180";
            txtBxBitly.Text = "544e7626db6de7861adf6e682e380dbff47890d4";

        }

        #endregion

    }
}
