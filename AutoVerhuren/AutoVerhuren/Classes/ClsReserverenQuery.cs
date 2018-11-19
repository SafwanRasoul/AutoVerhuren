using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AutoVerhuren.Classes {
    class ClsReserverenQuery {
        DbConnection conn = new DbConnection();
        public void insert(int auto_id, int klant_id, DateTime res_datum, DateTime eind_datum, bool status) {
           // int auto_id, int klant_id,
            string insQry = "INSERT INTO reserveren VALUES((SELECT auto_id FROM auto WHERE auto_id = '"+auto_id+"'), (SELECT klant_id FROM klant WHERE klant_id = '"+klant_id+"'), '" + res_datum + "', '" + eind_datum + "', '" + status + "')";

            SqlCommand cmd = new SqlCommand(insQry, conn.OpenConn());
            cmd.ExecuteNonQuery();
        }


        public void Wijzigen(int auto_id, int klant_id, DateTime res_datum, DateTime eind_datum, bool status, int res_id) {
            string EditQuery = "UPDATE reserveren  SET auto_id = '" + auto_id + "', klant_id = '" + klant_id + "', res_datum = '" + res_datum + "', eind_datum = '" + eind_datum + "', status = '" + status + "' WHERE res_id = '" + res_id + "'";
            SqlCommand sqlCommand = new SqlCommand(EditQuery, conn.OpenConn());
            sqlCommand.ExecuteNonQuery();
        }


        public int CheckReserverenIfExist(string auto_id) {

            string CheckQuery = "SELECT COUNT(*) FROM reserveren WHERE auto_id = '" + auto_id + "' AND status = 1";
            SqlCommand cmd = new SqlCommand(CheckQuery, conn.OpenConn());
            return (int)cmd.ExecuteScalar();

        }


        public void delete(int res_id) {

            conn.OpenConn();
            SqlDataAdapter sda = new SqlDataAdapter("DELETE FROM reserveren WHERE res_id = '" + res_id + "'", conn.OpenConn());
            sda.SelectCommand.ExecuteNonQuery();
            //DbConnection.Connection().Close();

            MessageBox.Show("Deleted");
        }


        public void SelectAll() {
            string SelQuery = "SELECT * FROM reserveren";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(SelQuery, conn.OpenConn());

        }


        public int SelectKlantId(string Naam) {
            string CheckQuery = "SELECT klant_id FROM klant WHERE naam = '" + Naam + "'";
            SqlCommand cmd = new SqlCommand(CheckQuery, conn.OpenConn());
            return (int)cmd.ExecuteScalar();
        }

        public int SelectAutoId(string Model) {
            string CheckQuery = "SELECT auto_id FROM auto WHERE model = '" + Model + "'";
            SqlCommand cmd = new SqlCommand(CheckQuery, conn.OpenConn());
            return (int)cmd.ExecuteScalar();
        }


    }
}
