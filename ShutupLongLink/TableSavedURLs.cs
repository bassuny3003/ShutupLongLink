using System.Data;
using System.Data.SQLite;

namespace ShutupLongLink
{

    class TableSavedURLs
    {
        #region Class Properties 

        public int ID { get; set; }
        public string UsedService { get; set; }
        public string LongURL { get; set; }
        public string ShortURL { get; set; }
        public string AliasURL { get; set; }
        public string NotesURL { get; set; }
        public long LastNewURLID { get; private set; }

        #endregion Class Properties 

        #region Variables

        SQLiteConnection MyConnection = AppConnections.GetSQLiteConnection();

        //DataTable MyDataTable = new DataTable();

        #endregion Variables

        #region Get All Saved URLs

        /// <summary>
        /// Get All Saved URLs
        /// </summary>
        /// <returns></returns>
        public DataTable GetAllSavedURLs()
        {
            DataTable MyDataTable = new DataTable();
            //SQLiteConnection MyConnection = AppConnections.GetSQLiteConnection();

            SQLiteCommand MySQLiteSearchCommand = new SQLiteCommand("Select * From SavedURLs", MyConnection);

            SQLiteDataAdapter MySQLiteDataAdapter = new SQLiteDataAdapter(MySQLiteSearchCommand);

            MyConnection.Open();

            MySQLiteDataAdapter.Fill(MyDataTable);

            MyConnection.Close();

            return MyDataTable;
        }

        #endregion Get All Saved URLs

        #region Save New URL

        /// <summary>
        /// Save New URL
        /// </summary>
        public void SaveNewURL()
        {
            //SQLiteConnection MyConnection = AppConnections.GetSQLiteConnection();

            SQLiteCommand MySQLiteInsertCommand = new SQLiteCommand("Insert Into SavedURLs (UsedService,LongURL,ShortURL,AliasURL,NotesURL) " +
                "Values (@UsedService,@LongURL,@ShortURL,@AliasURL,@NotesURL)", MyConnection);


            MySQLiteInsertCommand.Parameters.AddWithValue("@UsedService", this.UsedService);
            MySQLiteInsertCommand.Parameters.AddWithValue("@LongURL", this.LongURL);
            MySQLiteInsertCommand.Parameters.AddWithValue("@ShortURL", this.ShortURL);
            MySQLiteInsertCommand.Parameters.AddWithValue("@AliasURL", this.AliasURL);
            MySQLiteInsertCommand.Parameters.AddWithValue("@NotesURL", this.NotesURL);


            SQLiteCommand MySQLiteGetLastRowIDCommand = new SQLiteCommand("Select last_insert_rowid()", MyConnection);


            MyConnection.Open();

            MySQLiteInsertCommand.ExecuteNonQuery();

            this.LastNewURLID = (long)MySQLiteGetLastRowIDCommand.ExecuteScalar();

            MyConnection.Close();
        }

        #endregion Save New URL

        #region Get URL Notes Only

        /// <summary>
        /// Get URL Notes Only
        /// Need ID
        /// </summary>
        public DataTable GetURLNotes()
        {
            DataTable MyDataTable = new DataTable();

            SQLiteCommand MySQLiteSelectCommand = new SQLiteCommand("Select NotesURL From SavedURLs Where ID = @ID", MyConnection);

            MySQLiteSelectCommand.Parameters.AddWithValue("@ID", ID);

            SQLiteDataAdapter MySQLiteDataAdapter = new SQLiteDataAdapter(MySQLiteSelectCommand);


            MyConnection.Open();

            MySQLiteDataAdapter.Fill(MyDataTable);


            MyConnection.Close();

            return MyDataTable;
        }

        #endregion Get URL Notes Only

        #region Update URL Data With Notes

        /// <summary>
        /// Update URL Data With Notes
        /// Need ID,Notes
        /// </summary>
        public void SetNotesURL()
        {
            SQLiteCommand MySQLiteUpdateCommand = new SQLiteCommand("Update SavedURLs Set NotesURL = @NotesURL Where ID = @ID", MyConnection);

            MySQLiteUpdateCommand.Parameters.AddWithValue("@ID", ID);
            MySQLiteUpdateCommand.Parameters.AddWithValue("@NotesURL", this.NotesURL);

            MyConnection.Open();

            MySQLiteUpdateCommand.ExecuteNonQuery();

            MyConnection.Close();
        }

        #endregion Update URL Data With Notes

        #region Delete URL Data

        /// <summary>
        /// Delete Selected URL
        /// Need ID Only
        /// </summary>
        public void DeleteSelectedURL()
        {
            SQLiteCommand MySQLiteDeleteCommand = new SQLiteCommand("Delete From SavedURLs Where id = @id", MyConnection);

            MySQLiteDeleteCommand.Parameters.AddWithValue("@id", this.ID);

            MyConnection.Open();

            MySQLiteDeleteCommand.ExecuteNonQuery();

            MyConnection.Close();
        }

        #endregion Delete Product Data

    }
}
