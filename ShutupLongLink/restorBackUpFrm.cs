using System;
using System.IO;
using System.Windows.Forms;

namespace ShutupLongLink
{
    public partial class restorBackUpFrm : Form
    {
        #region Variables

        string ChoosedBackUp = "";

        public Form MyParent { get; set; }

        OpenFileDialog openFileDialog = new OpenFileDialog();

        #endregion

        #region Constractor

        public restorBackUpFrm()
        {
            InitializeComponent();
        }

        #endregion

        #region Browse DataBase BackUp Event

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //openFileDialog.FileName = "icon.ico";
            openFileDialog.InitialDirectory = AppConnections.DataBaseBackUpFolderPath;
            openFileDialog.ShowReadOnly = true;
            openFileDialog.ReadOnlyChecked = true;
            openFileDialog.Title = "Choose DataBase Path";
            openFileDialog.Filter = "BackUp DataBase File (*.dbBackup)|*.dbBackup";

            openFileDialog.ShowDialog();

            if (openFileDialog.FileName.ToString() == "")
            {
                return;
            }
            else
            {
                txtBxBackUpPath.Text = ChoosedBackUp = openFileDialog.FileName;
                lblChoosedFileName.Text = openFileDialog.SafeFileName;
            }
        }

        #endregion

        #region Check If Choosed BackUp File is Exists

        private void txtBxBackUpPath_TextChanged(object sender, EventArgs e)
        {
            if (File.Exists(txtBxBackUpPath.Text))
            {
                btnRestore.Enabled = true;
            }
            else
            {
                btnRestore.Enabled = false;
            }
        }

        #endregion

        #region Restore DataBase File Evnet

        private void btnRestore_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show(this, "You Are About To Restore DataBase File\n( " + lblChoosedFileName.Text + " )\nAre You Sure? ", "Restore DataBase", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    
                    File.Copy(ChoosedBackUp, AppConnections.DataBaseFolderPath + "SavedURLs.db", true);

                    MyParent.GetType().GetMethod("GetAllSavedURLs").Invoke(MyParent, null);

                    MessageBox.Show(this, "DataBaseFile Restored And Loaded, Have Nice Day :)", "Restore DataBase", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    break;
                default:
                    break;
            }
        }

        #endregion

        #region Close Event

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion



    }
}
