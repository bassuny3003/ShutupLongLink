using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ShutupLongLink
{
    public partial class MainFrm : Form
    {
        readonly string     DefaultAdflyAPIKey = "4035c8e1d3931ac1fec5f8d1cec122c1",
                            DefaultAdflyUID = "1503418",
                            DefaultShortestAPIKey = "b38880d274a8bd8e710bf1c47369242b",
                            DefaultR7URLAPIKey = "81ec9a87936f0b502f75cb6df8e71512aacddd6e";

        public MainFrm()
        {
            InitializeComponent();

            picBxService.Image = Properties.Resources.adfly;


            // Set Combo Box Defult Value (Commissions from Rented Referrals)
            var itemsService = new[] {
                new { Text = "Adfly", Value = "Adfly" },
                new { Text = "Shortest", Value = "Shortest" },
                new { Text = "R7URL", Value = "R7URL" },
                new { Text = "TinyURL", Value = "TinyURL" },
                new { Text = "Bitly", Value = "Bitly" },
            };

            cmbBxService.DataSource = itemsService;
            cmbBxService.DisplayMember = "Text";
            cmbBxService.ValueMember = "Value";

        }


        private void chkBxOnTop_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBxOnTop.Checked)
            {
                this.TopMost = true;
            }
            else
            {
                this.TopMost = false;
            }
        }

        private void submnuItm02_Click(object sender, EventArgs e)
        {
            chkBxOnTop.Checked = false;

            aboutForm aboutForm = new aboutForm();
            aboutForm.Owner = this;
            aboutForm.ShowDialog();
        }

        private void submnuItm01_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtBxLongURL_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBxLongURL.Text))
            {
                btnCpyShortURL.Enabled = false;

                txtBxShortURL.Clear();
            }
        }

        private void btnCpyShortURL_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtBxShortURL.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Width == 506)
            {
                this.Width = 1300;
                CenterToScreen();
                chkBxOnTop.Location = new Point(1174, 7);

            }
            else
            {
                this.Width = 506;
                CenterToScreen();
                chkBxOnTop.Location = new Point(392, 7);
            }

        }

        private void submnuItm07_Click(object sender, EventArgs e)
        {
            aPIMangerFrm aPIMangerFrm = new aPIMangerFrm();
            aPIMangerFrm.Owner = this;
            aPIMangerFrm.ShowDialog();
        }

        private void btnRunShortner_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBxLongURL.Text))
            {
                if (cmbBxService.Text == "Adfly")
                {
                    string AdType;

                    if (rbAdType1.Checked)
                        AdType = "int";
                    else
                        AdType = "banner";

                    if (!string.IsNullOrEmpty(Properties.Settings.Default.UserAdflyAPIKey) || !string.IsNullOrEmpty(Properties.Settings.Default.UserAdflyUID))
                    {
                        txtBxShortURL.Text = ShortURL.AdflyURLShortner(Properties.Settings.Default.UserAdflyAPIKey, Properties.Settings.Default.UserAdflyUID, AdType, txtBxLongURL.Text);
                    }
                    else
                    {
                        MessageBox.Show(this, "Please Add Your APIs Or Load Default First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        aPIMangerFrm aPIMangerFrm = new aPIMangerFrm();
                        aPIMangerFrm.Owner = this;
                        aPIMangerFrm.ShowDialog();
                    }

                }
                else if (cmbBxService.Text == "Shortest")
                {
                    picBxService.Image = Properties.Resources.logo_shortest;


                    if (!string.IsNullOrEmpty(Properties.Settings.Default.UserShortestAPIKey))
                    {
                        txtBxShortURL.Text = ShortURL.ShortestURLShortner(Properties.Settings.Default.UserShortestAPIKey, txtBxLongURL.Text);
                    }
                    else
                    {
                        MessageBox.Show(this, "Please Add Your APIs Or Load Default First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        aPIMangerFrm aPIMangerFrm = new aPIMangerFrm();
                        aPIMangerFrm.Owner = this;
                        aPIMangerFrm.ShowDialog();
                    }
                }
                else if (cmbBxService.Text == "R7URL")
                {
                    picBxService.Image = Properties.Resources.logo;

                    if (!string.IsNullOrEmpty(Properties.Settings.Default.UserR7APIKey))
                    {
                        if (string.IsNullOrEmpty(txtBxR7URLAlias.Text))
                        {
                            MessageBox.Show(this, "Please Check Alias Text", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            txtBxShortURL.Text = ShortURL.R7URLShortner(Properties.Settings.Default.UserR7APIKey, txtBxR7URLAlias.Text, txtBxLongURL.Text);
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "Please Add Your APIs Or Load Default First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        aPIMangerFrm aPIMangerFrm = new aPIMangerFrm();
                        aPIMangerFrm.Owner = this;
                        aPIMangerFrm.ShowDialog();
                    }
                }
                else if (cmbBxService.Text == "TinyURL")
                {
                    picBxService.Image = Properties.Resources.TinyURL_logo;

                    txtBxShortURL.Text = ShortURL.TinyURLShortner(txtBxLongURL.Text);
                }
                else if (cmbBxService.Text == "Bitly")
                {
                    picBxService.Image = Properties.Resources.Bit_ly_Logo_svg;

                    //foreach (var item in txtBxLongURL.Lines)
                    //{
                    //    txtBxShortURL.Text = txtBxShortURL.Text + item + Environment.NewLine;
                    //}
                }

                btnCpyShortURL.Enabled = true;
            }
            else
            {
                MessageBox.Show(this, "Please Add URLs First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (MessageBox.Show(this, "Are you sure you want to exit ?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    Process.GetCurrentProcess().Kill();
                    break;
                default:
                    e.Cancel = true;
                    break;
            }
        }

        private void cmbBxService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBxService.Text == "Adfly")
            {
                picBxService.Image = Properties.Resources.adfly;
                rbAdType1.Visible = true;
                rbAdType2.Visible = true;
                lblR7URLAlias.Visible = false;
                txtBxR7URLAlias.Visible = false;

            }
            else if (cmbBxService.Text == "Shortest")
            {
                picBxService.Image = Properties.Resources.logo_shortest;
                rbAdType1.Visible = false;
                rbAdType2.Visible = false;
                lblR7URLAlias.Visible = false;
                txtBxR7URLAlias.Visible = false;

            }
            else if (cmbBxService.Text == "R7URL")
            {
                picBxService.Image = Properties.Resources.logo;
                rbAdType1.Visible = false;
                rbAdType2.Visible = false;
                lblR7URLAlias.Visible = true;
                txtBxR7URLAlias.Visible = true;

            }
            else if (cmbBxService.Text == "TinyURL")
            {
                picBxService.Image = Properties.Resources.TinyURL_logo;
                rbAdType1.Visible = false;
                rbAdType2.Visible = false;
                lblR7URLAlias.Visible = false;
                txtBxR7URLAlias.Visible = false;

            }
            else if (cmbBxService.Text == "Bitly")
            {
                picBxService.Image = Properties.Resources.Bit_ly_Logo_svg;
                rbAdType1.Visible = false;
                rbAdType2.Visible = false;
                lblR7URLAlias.Visible = false;
                txtBxR7URLAlias.Visible = false;

            }
        }
    }
}
