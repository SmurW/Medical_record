using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Med_karta.Data
{
    class DataContext
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source= D:\1ProgramForPraktiki\База данных\Med_karta.accdb");

        public void Connection()
        {
            if (con.State == System.Data.ConnectionState.Closed)
                con.Open();
        }

        public void Disconnection()
        {
            if (con.State == System.Data.ConnectionState.Open)
                con.Close();
        }

        public OleDbConnection getConnection()
        {
            return con;
        }
    }
}
