using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace AutoVerhuren.Classes {
    class ClsKlantenQuery {
        DbConnection conn = new DbConnection();
        public void insert(string naam, string achternaam, string adres, int huis_nr, string postcode, string woonplaats, int doc_id, bool status) {

            string insQry = "INSERT INTO klant VALUES('" + naam + "', '" + achternaam + "', '" + adres + "', '" + huis_nr + "', '" + postcode + "', '" + woonplaats + "', '" + doc_id + "', '" + status + "')";
            SqlCommand cmd = new SqlCommand(insQry, conn.OpenConn());
            cmd.ExecuteNonQuery();
        }



        public void Wijzigen(string naam, string achternaam, string adres, int huis_nr, string postcode, string woonplaats, int doc_id, bool status, int klant_id) {
            string EditQuery = "UPDATE klant  SET naam = '" + naam + "', achternaam = '" + achternaam + "', adres = '" + adres + "', postcode = '" + postcode + "', woonplaats = '" + woonplaats + "', document_id = '" + doc_id + "', status = '" + status + "' WHERE klant_id = '" + klant_id + "'";
            SqlCommand sqlCommand = new SqlCommand(EditQuery, conn.OpenConn());
            sqlCommand.ExecuteNonQuery();
        }


        public void delete(int klant_id) {
            conn.OpenConn();
            SqlCommand sqlCommand = new SqlCommand("DELETE FROM klant WHERE klant_id = '" + klant_id + "'", conn.OpenConn());
            sqlCommand.ExecuteNonQuery();
            //DbConnection.Connection().Close();
        }


        public int CheckKlantIfExist(string doc_id) {
            conn.OpenConn();
            string CheckQuery = "SELECT COUNT(*) FROM klant WHERE document_id = '" + doc_id + "'";
            SqlCommand cmd = new SqlCommand(CheckQuery, conn.OpenConn());
            return (int)cmd.ExecuteScalar();

        }



    }
}
