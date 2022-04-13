using System.Data;
using System.Windows.Forms;

namespace ShutupLongLink
{
    public partial class noteEditeFrm : Form
    {
        #region Variables

        int SelectedID;

        public Form MyParent { get; set; }

        TableSavedURLs tableSavedURLs = new TableSavedURLs();

        #endregion

        #region Get Selected Notes By ID

        private string GetSelectedNotes(int sID)
        {
            tableSavedURLs.ID = sID;

            DataTable MyDataTable = tableSavedURLs.GetURLNotes();

            string NoteURL = MyDataTable.Rows[0]["NotesURL"].ToString();

            return NoteURL;
        }

        #endregion

        #region Constractor

        public noteEditeFrm(int ID)
        {
            InitializeComponent();

            SelectedID = ID;

            lblID.Text = SelectedID.ToString();
            txtBxNote.Text = GetSelectedNotes(SelectedID);
        }

        #endregion

        #region Close Event

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        #endregion

        #region Save Event

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            tableSavedURLs.ID = SelectedID;
            tableSavedURLs.NotesURL = txtBxNote.Text;

            tableSavedURLs.SetNotesURL();

            MyParent.GetType().GetMethod("GetAllSavedURLs").Invoke(MyParent, null);
        } 

        #endregion
    }
}
