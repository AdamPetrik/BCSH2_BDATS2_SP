using Microsoft.VisualBasic.ApplicationServices;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpravaObjednavek_GUI_App
{
    internal class DatabaseConnection
    {
        private static readonly string username = "ST72556";
        private static readonly string password = "z52keybysrRc";
        private static readonly string connectionString =
            $"User Id={username};Password={password};" +
            "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=fei-sql3.upceucebny.cz)(PORT=1521)))(CONNECT_DATA=(SID=BDAS)))";
        public static OracleConnection GetConnection()
        {
            OracleConnection conn = new OracleConnection(connectionString);
            conn.Open();
            return conn;
        }
    }
}
