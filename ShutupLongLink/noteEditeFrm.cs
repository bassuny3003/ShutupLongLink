using System.Data;
using System.Windows.Forms;

namespace ShutupLongLink
{
    public partial class noteEditeFrm : Form
    {
        int SelectedID;
        TableSavedURLs tableSavedURLs = new TableSavedURLs();

        private string GetSelectedNotes(int sID)
        {
            tableSavedURLs.ID = sID;

            DataTable MyDataTable = tableSavedURLs.GetURLNotes();

            string NoteURL = MyDataTable.Rows[0]["NotesURL"].ToString();

            return NoteURL; 
        }

        public noteEditeFrm(int ID)
        {
            InitializeComponent();

            SelectedID = ID;

            lblID.Text = SelectedID.ToString();
            txtBxNote.Text = GetSelectedNotes(SelectedID);
        }

        public Form MyParent { get; set; }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, System.EventArgs e)
        {
            tableSavedURLs.ID = SelectedID;
            tableSavedURLs.NotesURL = txtBxNote.Text;

            tableSavedURLs.SetNotesURL();

            MyParent.GetType().GetMethod("GetAllSavedURLs").Invoke(MyParent, null);
        }
    }
}
