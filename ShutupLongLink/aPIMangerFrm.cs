using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ShutupLongLink
{
    public partial class aPIMangerFrm : Form
    {

        #region Choose Service From Combo Box To Show Service GroupBox

        void ChooseService(GroupBox groupBoxName)
        {
            List<Control> GroupBoxCollection = Controls.OfType<GroupBox>().Cast<Control>().ToList();

            foreach (var GroupBox in GroupBoxCollection)
            {
                //GroupBox.Visible = false;

                if (GroupBox.Name == groupBoxName.Name)
                {
                    GroupBox.Visible = true;
                }
                else
                {
                    GroupBox.Visible = false;
                }
            }
        } 

        #endregion

        public aPIMangerFrm()
        {
            InitializeComponent();

            #region Set Combo Box Defult Value Service

            var itemsService = new[] {
                new { Text = "Adfly",     Value = "Adfly" },
                new { Text = "Shortest",  Value = "Shortest" },
                new { Text = "R7URL",     Value = "R7URL" },
                new { Text = "Rebrandly", Value = "Rebrandly" },
                new { Text = "Bitly",     Value = "Bitly" },
                new { Text = "PicSee",    Value = "PicSee" },
                new { Text = "Blink",     Value = "Blink" },
                new { Text = "TinyCC",     Value = "TinyCC" }
            };

            cmbBxService.DataSource = itemsService;
            cmbBxService.DisplayMember = "Text";
            cmbBxService.ValueMember = "Value";

            #endregion

            #region Get All API Keys From Settings

            txtBxAdfly.Text = Properties.Settings.Default.UserAdflyAPIKey;
            txtBxAdflyUID.Text = Properties.Settings.Default.UserAdflyUID;

            txtBxR7URL.Text = Properties.Settings.Default.UserR7APIKey;

            txtBxShortest.Text = Properties.Settings.Default.UserShortestAPIKey;

            txtBxRebrandly.Text = Properties.Settings.Default.UserRebrandlyAPIKey;

            txtBxBitly.Text = Properties.Settings.Default.UserbitlyAPIKey;

            txtBxPicsee.Text = Properties.Settings.Default.UserPicSeeAPIKey;

            txtBxBlinkEmail.Text = Properties.Settings.Default.UserBlinkEmail;

            txtBxBlinkAPI.Text = Properties.Settings.Default.UserBlinkAPI;


            #endregion
        }

        #region ComboBox Service

        private void cmbBxService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBxService.Text == "Adfly")
            {
                //grBxAdfly.Visible = true;
                //grBxAdfly.Location = new Point(10,60);

                //grBxShortest.Visible = false;
                //grBxRebrandly.Visible = false;
                //grBxBitly.Visible = false;
                //grBxR7URL.Visible = false;
                //grBxPicsee.Visible = false;
                //grBxBlink.Visible = false;

                ChooseService(grBxAdfly);

            }
            else if (cmbBxService.Text == "Shortest")
            {
                //grBxShortest.Visible = true;
                //grBxShortest.Location = new Point(10, 60);

                //grBxAdfly.Visible = false;
                //grBxRebrandly.Visible = false;
                //grBxBitly.Visible = false;
                //grBxR7URL.Visible = false;
                //grBxPicsee.Visible = false;
                //grBxBlink.Visible = false;

                ChooseService(grBxShortest);

            }
            else if (cmbBxService.Text == "R7URL")
            {
                //grBxR7URL.Visible = true;
                //grBxR7URL.Location = new Point(10, 60);

                //grBxAdfly.Visible = false;
                //grBxShortest.Visible = false;
                //grBxRebrandly.Visible = false;
                //grBxBitly.Visible = false;
                //grBxPicsee.Visible = false;
                //grBxBlink.Visible = false;

                ChooseService(grBxR7URL);

            }
            else if (cmbBxService.Text == "Bitly")
            {
                //grBxBitly.Visible = true;
                //grBxBitly.Location = new Point(10, 60);

                //grBxAdfly.Visible = false;
                //grBxShortest.Visible = false;
                //grBxRebrandly.Visible = false;
                //grBxPicsee.Visible = false;
                //grBxBlink.Visible = false;
                //grBxR7URL.Visible = false;

                ChooseService(grBxBitly);


            }
            else if (cmbBxService.Text == "Rebrandly")
            {
                //grBxRebrandly.Visible = true;
                //grBxRebrandly.Location = new Point(10, 60);

                //grBxAdfly.Visible = false;
                //grBxShortest.Visible = false;
                //grBxPicsee.Visible = false;
                //grBxBlink.Visible = false;
                //grBxR7URL.Visible = false;
                //grBxBitly.Visible = false;


                ChooseService(grBxRebrandly);


            }
            else if (cmbBxService.Text == "PicSee")
            {
                //grBxPicsee.Visible = true;
                //grBxPicsee.Location = new Point(10, 60);

                //grBxAdfly.Visible = false;
                //grBxShortest.Visible = false;
                //grBxBlink.Visible = false;
                //grBxR7URL.Visible = false;
                //grBxBitly.Visible = false;
                //grBxRebrandly.Visible = false;

                ChooseService(grBxPicsee);


            }
            else if (cmbBxService.Text == "Blink")
            {
                //grBxBlink.Visible = true;
                //grBxBlink.Location = new Point(10, 60);

                //grBxAdfly.Visible = false;
                //grBxShortest.Visible = false;
                //grBxR7URL.Visible = false;
                //grBxBitly.Visible = false;
                //grBxRebrandly.Visible = false;
                //grBxPicsee.Visible = false;

                ChooseService(grBxBlink);


            }
            else if (cmbBxService.Text == "TinyCC")
            {
                //grBxTinyCC.Visible = true;
                //grBxTinyCC.Location = new Point(10, 60);

                //grBxAdfly.Visible = false;
                //grBxShortest.Visible = false;
                //grBxR7URL.Visible = false;
                //grBxBitly.Visible = false;
                //grBxRebrandly.Visible = false;
                //grBxPicsee.Visible = false;

                //grBxTinyCC.BringToFront();
                //grBxTinyCC.Invalidate();

                ChooseService(grBxTinyCC);

            }

        }



        #endregion

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

            Properties.Settings.Default.UserPicSeeAPIKey = txtBxPicsee.Text;

            Properties.Settings.Default.UserBlinkEmail = txtBxBlinkEmail.Text;
            Properties.Settings.Default.UserBlinkAPI = txtBxBlinkAPI.Text;

            Properties.Settings.Default.UserTinyCCUserName = txtBxTinyCCUserName.Text;
            Properties.Settings.Default.UserTinyCCAPIKey = txtBxTinyCCAPIKey.Text;

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

            txtBxPicsee.Text = "20f07f91f3303b2f66ab6f61698d977d69b83d64";

            txtBxBlinkEmail.Text ="";
            txtBxBlinkAPI.Text = "";

            txtBxTinyCCUserName.Text = "";
            txtBxTinyCCAPIKey.Text = "";
        }

        #endregion

        #region Clear All API Keys Button

        private void btnClearAPIs_Click(object sender, EventArgs e)
        {
            txtBxAdfly.Text = string.Empty;
            txtBxAdflyUID.Text = string.Empty;

            txtBxShortest.Text = string.Empty;

            txtBxR7URL.Text = string.Empty;

            txtBxRebrandly.Text = string.Empty;
            
            txtBxBitly.Text = string.Empty;

            txtBxPicsee.Text = string.Empty;

            txtBxBlinkEmail.Text = string.Empty;
            txtBxBlinkAPI.Text = string.Empty;

            txtBxTinyCCUserName.Text = string.Empty;
            txtBxTinyCCAPIKey.Text = string.Empty;

        }

        #endregion








        private void aPIMangerFrm_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
