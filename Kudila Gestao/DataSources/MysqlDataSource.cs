using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Kudila_Gestao.DataSources
{
    internal class MysqlDataSource : IDataSource
    {

        public static DataTable sqlDT = new DataTable();
        //public static string connString = Properties.Settings.Default;
        MySqlConnection mySqlConnection = new  MySqlConnection(Kudila_Gestao.Properties.Settings.Default.ConnString);
        
        public void CloseConnection()
        {
            throw new NotImplementedException();
        }

        public int Execute(string query)
        {
            throw new NotImplementedException();
        }

        public int Execute(string query, params object[] args)
        {
            throw new NotImplementedException();
        }

        public bool OpenConnection()
        { 
            try
            {
                mySqlConnection.Open();
                return true;
            }
            catch {
                return false;
            }
        }

        public DataTable SelectAll(string query)
        {
            throw new NotImplementedException();
        }

        public DataTable SelectAll(string query, params string[] args)
        {
            throw new NotImplementedException();
        }

        public void UpdatePhoto(string columnName, string pathPhoto)
        {
            throw new NotImplementedException();
        }
    }
}
