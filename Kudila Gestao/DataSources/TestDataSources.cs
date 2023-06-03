using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kudila_Gestao.DataSources
{
    internal class TestDataSources : IDataSource
    {
        public  bool isMysql = true;
        public  string conn = "";
        MySqlConnection mySqlConnection = new MySqlConnection();
        SqlConnection SqlConnection = new SqlConnection();
        public TestDataSources() { }
        public bool OpenConnection()
        {
            try
            {
                if (isMysql) { 
                    mySqlConnection.ConnectionString = conn;
                    mySqlConnection.Open();
                }
                else
                {
                    mySqlConnection.ConnectionString = conn;
                    mySqlConnection.Open();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
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
