using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AutoVerhuren.Classes {

    class DbConnection {

        public SqlConnection OpenConn() {
            string str = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sa_ir\Desktop\AutoVerhuren\AutoVerhuren\AutosVerhuren.mdf;Integrated Security=True;Connect Timeout=30";

            SqlConnection con = new SqlConnection(str);
            con.Open();
            return con;
        }

    }

}
