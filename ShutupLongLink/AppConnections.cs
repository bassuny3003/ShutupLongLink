using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Runtime.InteropServices;

namespace ShutupLongLink
{
    public class AppConnections
    {
        public static string DataBaseFolderPath = Environment.CurrentDirectory + "\\LocalDataBase\\";
        public static string DataBaseFilePath   = Environment.CurrentDirectory + "\\LocalDataBase\\SavedURLs.db";

        public static string DataBaseBackUpFolderPath = Environment.CurrentDirectory + "\\LocalDataBase\\Backups\\";


        #region DataBase Connection String Builder For SQLite

        /// <summary>
        /// Put DataBase SQL String Connection In Class
        /// You Can Use It Anywhere In The App
        /// You Can Use It In "SQL & SQLite" 
        /// </summary>
        /// <returns>Retern SQL Connection String</returns>
        public static SQLiteConnection GetSQLiteConnection()
        {
            return new SQLiteConnection("Data Source = " + DataBaseFilePath + "; Version = 3");
        }

        #endregion DataBase Connection String Builder For SQLite

        #region Check Internet Avalible

        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);

        /// <summary>
        /// Check If Internet Connection Is Avalible
        /// 
        /// </summary>
        /// <returns>Retern "True or False"</returns>
        public static bool CheckInternetAvailable()
        {
            int Desc;
            bool CheckInternetResult;

            if (InternetGetConnectedState(out Desc, 0) == true)
            {
                CheckInternetResult = true;
            }
            else
            {
                CheckInternetResult = false;
            }

            return CheckInternetResult;
        }

        #endregion Check Internet Avalible

        #region Check DataBase Connection

        /// <summary>
        /// Check DataBase Connection Is Avalible
        /// </summary>
        /// <returns>Retern "True Or False"</returns>
        public static bool CheckDataBaseConnection()
        {
            bool CheckDataBaseResult;

            SQLiteConnection MyConnetion = GetSQLiteConnection();

            MyConnetion.Open();

            if (MyConnetion.State == ConnectionState.Open)
            {
                CheckDataBaseResult = true;
            }
            else
            {
                CheckDataBaseResult = false;
            }

            MyConnetion.Close();

            return CheckDataBaseResult;
        }

        #endregion Check DataBase Connection

        #region Set DataBase Folder Path

        public void SetDataBaseFolderPath()
        {

        }

        #endregion Set DataBase Folder Path        
        
        #region Change DataBase Folder Path

        public void ChangeDataBaseFolderPath()
        {

        }

        #endregion Change DataBase Folder Path

        #region Backup Database File 

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static bool BackUpDataBase()
        {
            string TodayDate = DateTime.Now.ToString("ddMMyyyy");
            string TodayTime = DateTime.Now.ToString("hhmmss tt");

            bool Result = false;

            if (Directory.Exists(DataBaseFolderPath))
            {
                if (File.Exists(DataBaseFilePath))
                {
                    if (Directory.Exists(DataBaseBackUpFolderPath))
                    {
                        if (!File.Exists(DataBaseBackUpFolderPath + "SavedURLs - Date " + TodayDate + " Time " + TodayTime + " .dbBackup"))
                        {
                            File.Copy(DataBaseFilePath, DataBaseBackUpFolderPath + "SavedURLs - Date " + TodayDate + " Time " + TodayTime + " .dbBackup");
                            Result = true;
                        }
                        else
                        {
                            Result = false;
                        }
                    }
                    else
                    {
                        Directory.CreateDirectory(DataBaseBackUpFolderPath);
                        File.Copy(DataBaseFilePath, DataBaseBackUpFolderPath + "SavedURLs - Date " + TodayDate + " Time " + TodayTime + " .dbBackup");
                        Result = true;
                    }
                }
                else
                {
                    Result = false;
                }
            }
            else
            {
                Result = false;

            }

            return Result;
        }

        #endregion Backup Database File 

        #region Restore Database File

        /// <summary>
        /// 
        /// </summary>
        /// <param name="DataBaseFilePath"></param>
        /// <returns></returns>
        public bool RestoreDataBase(String DataBaseFilePath)
        {
            //bool Result = false;





            return true;
        }


        #endregion

    }
}