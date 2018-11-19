using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace AutoVerhuren.Classes {

    class ClsAutoQuery {
        DbConnection conn = new DbConnection();
        public void insert(string merk, string model, int bouwjaar, string kleur, string brandstof, int huurprijs, string kenteken, bool staus) {

            string insQry = "INSERT INTO auto VALUES('" + merk+"', '"+model+"', '"+bouwjaar+"', '"+kleur+"', '"+brandstof+"', '"+huurprijs+"', '"+kenteken+"', '"+staus+"')";

            SqlCommand cmd = new SqlCommand(insQry, conn.OpenConn());
            cmd.ExecuteNonQuery();
        }

        public void wijzigen(string merk, string model, int bouwjaar, string kleur, string brandstof, int huurprijs, string kenteken, bool staus, string setkenteken) {
            SqlCommand EditQuery = new SqlCommand("UPDATE auto  SET merk = '" + merk + "', model = '" + model + "', bouwjaar = '" + bouwjaar + "', kleur = '" + kleur + "', brandstof = '" 
                + brandstof + "', huurprijs = '" + huurprijs + "', kenteken = '" + kenteken + "', status = '" + staus + "' WHERE kenteken = '" + setkenteken + "'", conn.OpenConn());
            EditQuery.ExecuteNonQuery();
        }




        public void delete(string kenteken) {

            conn.OpenConn();
            SqlDataAdapter sda = new SqlDataAdapter("DELETE FROM auto WHERE kenteken = '" + kenteken + "'", conn.OpenConn());
            sda.SelectCommand.ExecuteNonQuery();
            conn.OpenConn();

            MessageBox.Show("Deleted");
        }


        public int CheckKentekenIfExist(string kenteken) {

            string CheckQuery = "SELECT COUNT(*) FROM auto WHERE kenteken = '" + kenteken + "'";
            SqlCommand cmd = new SqlCommand(CheckQuery, conn.OpenConn());
            return (int)cmd.ExecuteScalar(); ;

        }




    }

}
