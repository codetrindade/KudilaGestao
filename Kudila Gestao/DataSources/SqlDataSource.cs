using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kudila_Gestao.DataSources
{
    internal class SqlDataSource : IDataSource
    {
        SqlConnection connection = new SqlConnection(Properties.Settings.Default.ConnString);
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        SqlDataAdapter da;
 
        public void OpenConnection()
        {
            try { connection.Open(); } catch { }
        }
        public void CloseConnection()
        {
            try { connection.Close(); } catch { }
        }

        public int Execute(string query)
        {
            OpenConnection();
            using (cmd = new SqlCommand(query, connection))
            {
                return cmd.ExecuteNonQuery();
            }

        }

        public int Execute(string query, params object[] args)
        {
            using (cmd = new SqlCommand(query, connection))
            {
                for (int i = 0; i < args.Length; i++)
                {
                    string parameterName = $"@param{i + 1}";
                    cmd.Parameters.AddWithValue(parameterName, args[i]);
                }
                return cmd.ExecuteNonQuery();
            }
        }
        public DataTable SelectAll(string query)
        {
            using (cmd = new SqlCommand(query, connection))
            {
                DataTable dataTable = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dataTable);
                }
                return dataTable;
            }
        }

        public DataTable SelectAll(string query, params string[] args)
        {
            using (SqlCommand command = new SqlCommand(query, connection))
            {
               
                for (int i = 0; i < args.Length; i++)
                {
                    string parameterName = $"@param{i + 1}";
                    command.Parameters.AddWithValue(parameterName, args[i]);
                }
                DataTable dataTable = new DataTable();
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    adapter.Fill(dataTable);
                }
                return dataTable;
            }
        }

        public void UpdatePhoto(string tableName, string pathPhoto)
        {
            using (SqlCommand command = new SqlCommand())
            {
                command.Connection = connection;
                command.Parameters.AddWithValue("@photo", pathPhoto);
                string query = $"UPDATE {tableName} SET photo = @photo WHERE id = @id";
                command.CommandText = query;
                command.ExecuteNonQuery();
            }
        }
    }
}
