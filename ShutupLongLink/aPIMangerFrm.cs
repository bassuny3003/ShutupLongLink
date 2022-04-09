using System;
using System.Windows.Forms;

namespace ShutupLongLink
{
    public partial class aPIMangerFrm : Form
    {
        public aPIMangerFrm()
        {
            InitializeComponent();

            txtBxAdfly.Text = Properties.Settings.Default.UserAdflyAPIKey;
            txtBxAdflyUID.Text = Properties.Settings.Default.UserAdflyUID;

            txtBxR7URL.Text = Properties.Settings.Default.UserR7APIKey;

            txtBxShortest.Text = Properties.Settings.Default.UserShortestAPIKey;

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.UserAdflyAPIKey = txtBxAdfly.Text;
            Properties.Settings.Default.UserAdflyUID = txtBxAdflyUID.Text;

            Properties.Settings.Default.UserR7APIKey = txtBxR7URL.Text;

            Properties.Settings.Default.UserShortestAPIKey = txtBxShortest.Text;

            Properties.Settings.Default.Save();

            Close();


        }

        private void btnLoadDefault_Click(object sender, EventArgs e)
        {
            txtBxAdfly.Text = "4035c8e1d3931ac1fec5f8d1cec122c1";
            txtBxAdflyUID.Text = "1503418";
            txtBxShortest.Text = "b38880d274a8bd8e710bf1c47369242b";
            txtBxR7URL.Text = "81ec9a87936f0b502f75cb6df8e71512aacddd6e";

        }
    }
}
