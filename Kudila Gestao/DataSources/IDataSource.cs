using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kudila_Gestao.DataSources
{
    internal interface IDataSource
    {
        bool OpenConnection();
        void CloseConnection();
        int Execute(string query);
        int Execute(string query, params object[] args);
        DataTable SelectAll(string query);
        DataTable SelectAll(string query, params string[] args);
        void UpdatePhoto(string columnName, string pathPhoto);

    }
  
}
