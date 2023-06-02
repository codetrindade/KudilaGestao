using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kudila_Gestao.DataSources
{
    internal class MysqlDataSource : IDataSource
    {
        public static DataTable sqlDT = new DataTable();
        public static string appPathPaciente = Application.StartupPath + @"\paciente\";
        public static string appPathAvatar = Application.StartupPath + @"\avatar\";
        //public static string connString = Properties.Settings.Default;
        public static string sqlString;
        public static string tmpStr;
        public static string xUserPassword;
        public static int userID;
        public static string userName;
        public static string userFullName;
        public static string userFuncao;
        public static string userEmail;
        public static int LOGID;

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

        public void OpenConnection()
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
