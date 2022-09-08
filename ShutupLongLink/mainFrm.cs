using AdFlyAPIv1;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace ShutupLongLink
{
    public partial class MainFrm : Form
    {
        #region Variables

        TableSavedURLs TableSavedURLs = new TableSavedURLs();

        #endregion

        #region Get All ( Refresh ) Saved URLs In DataBase 

        public void GetAllSavedURLs()
        {
            //lstVw.Refresh();
            lstVw.Items.Clear();
            lstVw.Update();

            DataTable MyDataTable = TableSavedURLs.GetAllSavedURLs();

            if (MyDataTable.Rows.Count > 0)
            {
                for (int i = 0; i < MyDataTable.Rows.Count; i++)
                {
                    ListViewItem lstvwItm = new ListViewItem(MyDataTable.Rows[i]["id"].ToString());
                    lstvwItm.SubItems.Add(MyDataTable.Rows[i]["UsedService"].ToString());
                    lstvwItm.SubItems.Add(MyDataTable.Rows[i]["LongURL"].ToString());
                    lstvwItm.SubItems.Add(MyDataTable.Rows[i]["ShortURL"].ToString());
                    lstvwItm.SubItems.Add(MyDataTable.Rows[i]["AliasURL"].ToString());
                    lstvwItm.SubItems.Add(MyDataTable.Rows[i]["NotesURL"].ToString());

                    lstVw.Items.Add(lstvwItm);

                }

                lstVw.Refresh();
                lstVw.Focus();
                lstVw.Items[0].Selected = true;
            }
            else
            {
                lstVw.Items.Clear();
                lstVw.Update();

            }
        }

        #endregion

        #region Constractor

        public MainFrm()
        {
            InitializeComponent();

            #region Set Combo Box Defult Value Service

            var itemsService = new[] {
                new { Text = "Adfly",     Value = "Adfly" },
                new { Text = "Shortest",  Value = "Shortest" },
                new { Text = "R7URL",     Value = "R7URL" },
                new { Text = "TinyURL",   Value = "TinyURL" },
                new { Text = "Rebrandly", Value = "Rebrandly" },
                new { Text = "Bitly",     Value = "Bitly" },
            };

            cmbBxService.DataSource = itemsService;
            cmbBxService.DisplayMember = "Text";
            cmbBxService.ValueMember = "Value";

            #endregion

            #region Set Combo Box Defult Value AdFly Domains

            var itemsDomains = new[] {
                new { Text = "j.gs",     Value = "j.gs" },
                new { Text = "q.gs",  Value = "q.gs" }
            };

            cmbBxAdFlyDomains.DataSource = itemsDomains;
            cmbBxAdFlyDomains.DisplayMember = "Text";
            cmbBxAdFlyDomains.ValueMember = "Value";

            #endregion

            #region Set App Version In App Titel

            this.Text = Text + " Version: " + Application.ProductVersion;

            #endregion

            #region Get All Saved URLs From DB

            GetAllSavedURLs(); 

            #endregion

        }
        
        #endregion

        #region All Menu Code Events

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

        private void submnuItm03_Click(object sender, EventArgs e)
        {
            cmbBxService.SelectedIndex = 0;
        }
        private void submnuItm04_Click(object sender, EventArgs e)
        {
            cmbBxService.SelectedIndex = 1;
        }

        private void submnuItm05_Click(object sender, EventArgs e)
        {
            cmbBxService.SelectedIndex = 2;

        }

        private void submnuItm06_Click(object sender, EventArgs e)
        {
            cmbBxService.SelectedIndex = 3;

        }
        private void submnuItm11_Click(object sender, EventArgs e)
        {
            cmbBxService.SelectedIndex = 4;
        }
        private void submnuItm12_Click(object sender, EventArgs e)
        {
            cmbBxService.SelectedIndex = 5;
        }

        private void submnuItm07_Click(object sender, EventArgs e)
        {
            chkBxOnTop.Checked = false;

            aPIMangerFrm aPIMangerFrm = new aPIMangerFrm();
            aPIMangerFrm.Owner = this;
            aPIMangerFrm.ShowDialog();
        }

        private void submnuItm08_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show(this, "You Are About To BackUp DataBase File , Are You Sure ?", "BackUp DataBase", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    if (AppConnections.BackUpDataBase())
                    {
                        MessageBox.Show(this, "BackUp DataBase File Done, Have Nice Day :)", "BackUp DataBase", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(this, "Something Went Wrong , Maybe backUp File Already Exist :)", "BackUp DataBase", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    break;
                default:
                    break;
            }

        }

        private void submnuItm09_Click(object sender, EventArgs e)
        {
            chkBxOnTop.Checked = false;

            restorBackUpFrm restorBackUpFrm = new restorBackUpFrm();
            restorBackUpFrm.MyParent = this;
            restorBackUpFrm.ShowDialog();
        }

        private void submnuItm10_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show(this, "You Are About To Clear All DataBase Data \n# You Will canNOT Restore This Data Again #\nAre You Sure ?", "Clear DataBase", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    TableSavedURLs.DeleteAllSavedURLs();

                    MessageBox.Show(this, "All DataBase Data has Been Cleared.", "BackUp DataBase", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    GetAllSavedURLs();
                    break;
                default:
                    break;
            }
        }

        #endregion

        #region Form Closing Event

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

        #endregion

        #region ComboBox Service

        private void cmbBxService_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBxService.Text == "Adfly")
            {
                picBxService.Image = Properties.Resources.adfly;

                txtBxR7URLAlias.Clear();

                rbAdType1.Visible       = true;
                rbAdType2.Visible       = true;
                lblAdFlyDomains.Visible = true;
                cmbBxAdFlyDomains.Visible = true;
                lblR7URLAlias.Visible   = false;
                txtBxR7URLAlias.Visible = false;

            }
            else if (cmbBxService.Text == "Shortest")
            {
                picBxService.Image = Properties.Resources.logo_shortest;

                txtBxR7URLAlias.Clear();

                rbAdType1.Visible       = false;
                rbAdType2.Visible       = false;
                lblAdFlyDomains.Visible = false;
                cmbBxAdFlyDomains.Visible = false;
                lblR7URLAlias.Visible   = false;
                txtBxR7URLAlias.Visible = false;

            }
            else if (cmbBxService.Text == "R7URL")
            {
                picBxService.Image      = Properties.Resources.logo;
                rbAdType1.Visible       = false;
                rbAdType2.Visible       = false;
                lblAdFlyDomains.Visible = false;
                cmbBxAdFlyDomains.Visible = false;
                lblR7URLAlias.Visible   = true;
                txtBxR7URLAlias.Visible = true;

            }
            else if (cmbBxService.Text == "TinyURL")
            {
                txtBxR7URLAlias.Clear();

                picBxService.Image      = Properties.Resources.TinyURL_logo;
                rbAdType1.Visible       = false;
                rbAdType2.Visible       = false;
                lblAdFlyDomains.Visible = false;
                cmbBxAdFlyDomains.Visible = false;
                lblR7URLAlias.Visible   = false;
                txtBxR7URLAlias.Visible = false;

            }
            else if (cmbBxService.Text == "Bitly")
            {
                txtBxR7URLAlias.Clear();

                picBxService.Image      = Properties.Resources.Bit_ly_Logo_svg;
                rbAdType1.Visible       = false;
                rbAdType2.Visible       = false;
                lblAdFlyDomains.Visible = false;
                cmbBxAdFlyDomains.Visible = false;
                lblR7URLAlias.Visible   = false;
                txtBxR7URLAlias.Visible = false;

            }
            else if (cmbBxService.Text == "Rebrandly")
            {
                txtBxR7URLAlias.Clear();

                picBxService.Image      = Properties.Resources.rebrand_ly;
                rbAdType1.Visible       = false;
                rbAdType2.Visible       = false;
                lblAdFlyDomains.Visible = false;
                cmbBxAdFlyDomains.Visible = false;
                lblR7URLAlias.Visible   = false;
                txtBxR7URLAlias.Visible = false;

            }
        }

        #endregion

        #region Long URL TextBox

        private void txtBxLongURL_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBxLongURL.Text))
            {
                btnCpyShortURL.Enabled = false;

                txtBxShortURL.Clear();
            }
        }

        #endregion

        #region Run Shortner Button
        private async void btnRunShortner_Click(object sender, EventArgs e)
        {
            txtBxShortURL.Clear();

            if (!string.IsNullOrEmpty(txtBxLongURL.Text))
            {
                if (cmbBxService.Text == "Adfly")
                {
                    string AdType;

                    if (rbAdType1.Checked)
                        AdType = "int";
                    else
                        AdType = "banner";

                    List<string> LongURLs = new List<string>();

                    foreach (var Line in txtBxLongURL.Lines)
                    {
                        LongURLs.Add(Line);
                    }

                    if (!string.IsNullOrEmpty(Properties.Settings.Default.UserAdflyAPIKey) || !string.IsNullOrEmpty(Properties.Settings.Default.UserAdflyUID))
                    {
                        try
                        {
                            AdflyApi adflyApi = new AdflyApi(Properties.Settings.Default.UserAdflyAPIKey, Convert.ToUInt64(Properties.Settings.Default.UserAdflyUID));

                            string JSONResponce = adflyApi.Shorten(LongURLs, cmbBxAdFlyDomains.Text, AdType, 0);

                            JObject JSONObject = JObject.Parse(JSONResponce);

                            JArray JSONArray = (JArray)JSONObject["data"];

                            List<ResponseData> Response = JSONArray.ToObject<List<ResponseData>>();

                            for (int i = 0; i < Response.Count; i++)
                            {
                                txtBxShortURL.Text += Response[i].short_url + Environment.NewLine;

                                TableSavedURLs tableSavedURLs = new TableSavedURLs()
                                {
                                    AliasURL = "",
                                    UsedService = "https://adf.ly",
                                    LongURL = Response[i].url,
                                    ShortURL = Response[i].short_url,
                                    NotesURL = ""

                                };

                                tableSavedURLs.SaveNewURL();
                            }

                            GetAllSavedURLs();
                        }
                        catch (Exception)
                        {

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
                else if (cmbBxService.Text == "Shortest")
                {

                    if (!string.IsNullOrEmpty(Properties.Settings.Default.UserShortestAPIKey))
                    {
                        txtBxShortURL.Text = ShortURL.ShortestURLShortener(Properties.Settings.Default.UserShortestAPIKey, txtBxLongURL.Text);

                        TableSavedURLs tableSavedURLs = new TableSavedURLs()
                        {
                            AliasURL = txtBxR7URLAlias.Text,
                            UsedService = "https://shorte.st",
                            LongURL = txtBxLongURL.Text,
                            ShortURL = txtBxShortURL.Text,
                            NotesURL = ""

                        };

                        tableSavedURLs.SaveNewURL();

                        GetAllSavedURLs();
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

                    if (!string.IsNullOrEmpty(Properties.Settings.Default.UserR7APIKey))
                    {
                        if (string.IsNullOrEmpty(txtBxR7URLAlias.Text))
                        {
                            MessageBox.Show(this, "Please Check Alias Text", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                        else
                        {
                            txtBxShortURL.Text = ShortURL.R7URLShortener(Properties.Settings.Default.UserR7APIKey, txtBxR7URLAlias.Text, txtBxLongURL.Text);

                            TableSavedURLs tableSavedURLs = new TableSavedURLs()
                            {
                                AliasURL = txtBxR7URLAlias.Text,
                                UsedService = "https://7r6.com",
                                LongURL = txtBxLongURL.Text,
                                ShortURL = txtBxShortURL.Text,
                                NotesURL = ""

                            };

                            tableSavedURLs.SaveNewURL();

                            GetAllSavedURLs();
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

                    txtBxShortURL.Text = ShortURL.TinyURLShortener(txtBxLongURL.Text);

                    TableSavedURLs tableSavedURLs = new TableSavedURLs()
                    {
                        AliasURL = txtBxR7URLAlias.Text,
                        UsedService = "https://tinyurl.com",
                        LongURL = txtBxLongURL.Text,
                        ShortURL = txtBxShortURL.Text,
                        NotesURL = ""

                    };

                    tableSavedURLs.SaveNewURL();

                    GetAllSavedURLs();


                }
                else if (cmbBxService.Text == "Bitly")
                {
                    if (!string.IsNullOrEmpty(Properties.Settings.Default.UserbitlyAPIKey))
                    {
                        txtBxShortURL.Text = await ShortURL.bitlyShortenerAsync(Properties.Settings.Default.UserbitlyAPIKey, txtBxLongURL.Text);

                        TableSavedURLs tableSavedURLs = new TableSavedURLs()
                        {
                            UsedService = "https://bit.ly",
                            LongURL = txtBxLongURL.Text,
                            ShortURL = txtBxShortURL.Text,
                            NotesURL = ""

                        };

                        tableSavedURLs.SaveNewURL();

                        GetAllSavedURLs();
                    }
                    else
                    {
                        MessageBox.Show(this, "Please Add Your APIs Or Load Default First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        aPIMangerFrm aPIMangerFrm = new aPIMangerFrm();
                        aPIMangerFrm.Owner = this;
                        aPIMangerFrm.ShowDialog();
                    }

                }
                else if (cmbBxService.Text == "Rebrandly")
                {
                    if (!string.IsNullOrEmpty(Properties.Settings.Default.UserRebrandlyAPIKey))
                    {
                        txtBxShortURL.Text = await ShortURL.RebrandlyShortenerAsync(Properties.Settings.Default.UserRebrandlyAPIKey, txtBxLongURL.Text);

                        TableSavedURLs tableSavedURLs = new TableSavedURLs()
                        {
                            UsedService = "https://rebrand.ly",
                            LongURL = txtBxLongURL.Text,
                            ShortURL = txtBxShortURL.Text,
                            NotesURL = ""

                        };

                        tableSavedURLs.SaveNewURL();

                        GetAllSavedURLs();
                    }
                    else
                    {
                        MessageBox.Show(this, "Please Add Your APIs Or Load Default First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        aPIMangerFrm aPIMangerFrm = new aPIMangerFrm();
                        aPIMangerFrm.Owner = this;
                        aPIMangerFrm.ShowDialog();
                    }
                }

                statusLbl01.Text = "Check Your Short URLs";
                timrCpyShortURL.Interval = 5000;
                timrCpyShortURL.Start();

                btnCpyShortURL.Enabled = true;
            }
            else
            {
                statusLbl01.Text = "Please Add URLs First";
                timrCpyShortURL.Interval = 5000;
                timrCpyShortURL.Start();

                MessageBox.Show(this, "Please Add URLs First", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        #endregion

        #region Copy Short URL Button

        private void btnCpyShortURL_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtBxShortURL.Text);

            statusLbl01.Text = "ShortURL Copied";
            timrCpyShortURL.Interval = 5000;
            timrCpyShortURL.Start();
        }

        private void timrCpyShortURL_Tick(object sender, EventArgs e)
        {
            statusLbl01.Text = "";
        }

        #endregion

        #region Open Local DateBase Button

        private void btnOpenLocalDateBase_Click(object sender, EventArgs e)
        {
            if (Width == 506)
            {
                this.Width = 1300;
                CenterToScreen();
                chkBxOnTop.Location = new Point(1174, 7);
                btnOpenLocalDateBase.Text = "Open Local Data Base      <<<<<<<<<<";

            }
            else
            {
                this.Width = 506;
                CenterToScreen();
                chkBxOnTop.Location = new Point(392, 7);
                btnOpenLocalDateBase.Text = "Open Local Data Base      >>>>>>>>>>";
            }

        }


        #endregion

        #region Rigt Click List View Events

        private void lstVw_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                rightClickLstVw.Show(lstVw, new Point(e.X, e.Y));

            }
        }
        private void EditeNotesURL_Click(object sender, EventArgs e)
        {
            int selectedItems = Convert.ToInt32(lstVw.SelectedItems[0].Text);

            noteEditeFrm noteEditeFrm = new noteEditeFrm(selectedItems);

            noteEditeFrm.MyParent = this;
            noteEditeFrm.ShowDialog();

        }

        private void CopyWholeRow_Click(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selectedItems = lstVw.SelectedItems;

            String WholeRowText = "";

            foreach (ListViewItem item in selectedItems)
            {
                for (int i = 1; i < item.SubItems.Count; i++)
                {
                    WholeRowText += "\" " + item.SubItems[i].Text + "\" ";
                }
            }

            Clipboard.SetText(WholeRowText);
        }

        private void CopyLongURL_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lstVw.SelectedItems[0].SubItems[2].Text))
            {
                Clipboard.SetText(lstVw.SelectedItems[0].SubItems[2].Text);
            }
            else
            {
                Clipboard.Clear();
            }
        }

        private void CopyShortURL_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lstVw.SelectedItems[0].SubItems[3].Text))
            {
                Clipboard.SetText(lstVw.SelectedItems[0].SubItems[3].Text);
            }
            else
            {
                Clipboard.Clear();
            }
        }

        private void CopyAliasURL_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lstVw.SelectedItems[0].SubItems[4].Text))
            {
                Clipboard.SetText(lstVw.SelectedItems[0].SubItems[4].Text);
            }
            else
            {
                Clipboard.Clear();
            }
        }

        private void CopyNotesURL_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(lstVw.SelectedItems[0].SubItems[5].Text))
            {
                Clipboard.SetText(lstVw.SelectedItems[0].SubItems[5].Text);
            }
            else
            {
                Clipboard.Clear();
            }
        }

        private void GoToServiceWebSite_Click(object sender, EventArgs e)
        {
            StartURLInBrowser.Url = lstVw.SelectedItems[0].SubItems[1].Text;
            StartURLInBrowser.StartDefualtBrowser();
        }

        private void GoToLongURL_Click(object sender, EventArgs e)
        {
            StartURLInBrowser.Url = lstVw.SelectedItems[0].SubItems[2].Text;
            StartURLInBrowser.StartDefualtBrowser();
        }

        private void GoToShortURL_Click(object sender, EventArgs e)
        {
            StartURLInBrowser.Url = lstVw.SelectedItems[0].SubItems[3].Text;
            StartURLInBrowser.StartDefualtBrowser();
        }

        private void DeleteSelectedURL_Click(object sender, EventArgs e)
        {
            int ChoosedID = Convert.ToInt32(lstVw.SelectedItems[0].Text);

            switch (MessageBox.Show(this, "You Are About To Delete URL With ID : ( " + ChoosedID + " ) Are You Sure ?", "Delete URL", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:

                    TableSavedURLs tableSavedURLs = new TableSavedURLs()
                    {
                        ID = ChoosedID
                    };
                    tableSavedURLs.DeleteSelectedURL();

                    GetAllSavedURLs();

                    break;
                default:
                    break;
            }
        }

        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            //lstVw.Items.Clear();


        }


    }
}
