using Kudila_Gestao.DataSources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kudila_Gestao.Controllers
{
    internal class DbSettings
    {
        TestDataSources connSource = new TestDataSources();
       
        public bool Connect(String User, String Password, String Database, bool isMysqlDataBase = true)
        {
            try
            {
                if (isMysqlDataBase) {
                    connSource.isMysql = true;
                    connSource.conn = "server=localhost;uid=root; database=db_Comercial;uid=root;pwd=";
                }
                else
                {
                    connSource.isMysql = false;
                    connSource.conn = "server=localhost;uid=root; database=db_Comercial;uid=root;pwd=";

                }
                return (connSource.OpenConnection());
            }
            catch 
            {
                return false;

            }
        }
    }
}
