using System;
using System.IO;
using System.Windows.Forms;

namespace ShutupLongLink
{
    public partial class restorBackUpFrm : Form
    {
        public Form MyParent { get; set; }

        string ChoosedBackUp = "";

        OpenFileDialog openFileDialog = new OpenFileDialog();

        public restorBackUpFrm()
        {
            InitializeComponent();
        }

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

        private void btnRestore_Click(object sender, EventArgs e)
        {
            switch (MessageBox.Show(this, "You Are About To Restore DataBase File\n( " + lblChoosedFileName.Text + " )\nAre You Sure? ", "Restore DataBase", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                case DialogResult.Yes:
                    File.Copy(ChoosedBackUp, AppConnections.DataBaseFolderPath + "SavedURLs.db", true);

                    MyParent.GetType().GetMethod("GetAllSavedURLs").Invoke(MyParent, null);

                    MessageBox.Show(this, "DataBaseFile RestoredAnd Loaded, Have Nice Day :)", "Restore DataBase", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    break;
                default:
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
