using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoVerhuren.Classes {
    class Querys {
        DbConnection conn = new DbConnection();
        SqlCommand sqlCmd = new SqlCommand();

        //Get Klanten from DB
        public void GetData(String mode, DataGridView gridview) {
            SqlDataAdapter dadapter = new SqlDataAdapter();
            SqlCommand sqlCmd = new SqlCommand("SelKlanten", conn.OpenConn());
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@mode", mode);
            dadapter.SelectCommand = sqlCmd;
            DataTable table = new DataTable();
            dadapter.Fill(table);
            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            gridview.DataSource = bSource;
            conn.OpenConn().Close();
        }

        //Get Data By Document ID from DB
        public void GetDataByDocId(DataGridView gridview,TextBox text, Label label) {
            SqlDataAdapter dadapter = new SqlDataAdapter();
            SqlCommand sqlCmd = new SqlCommand("SelKlanten", conn.OpenConn());
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@mode", "doc_id");
            dadapter.SelectCommand = sqlCmd;
            DataTable table = new DataTable();
            dadapter.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            object sql = sqlCmd.ExecuteScalar();
            int i;
            //Zoekbalk controleren
            if (string.IsNullOrWhiteSpace(text.Text)) {
                MessageBox.Show("Zoekbalk is leeg.", "Fout Melding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (!int.TryParse(text.Text, out i)) {
                MessageBox.Show("Voer alleen nummer in", "Fout Melding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else {
                label.Text = sqlCmd.ToString();
                gridview.DataSource = bSource;
            }
            conn.OpenConn().Close();

        }

        //Check if Klant Exist in DB
        public int CheckKlantIfExist(TextBox doc_id,Label label) {
            sqlCmd = new SqlCommand("SelKlanten", conn.OpenConn());
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.AddWithValue("@doc_id", Convert.ToInt32(doc_id.Text));
            int cmd = (int)sqlCmd.ExecuteScalar();

            if (string.IsNullOrWhiteSpace(doc_id.Text)) {
                MessageBox.Show("Voer a.u.b. klant Document-ID in.", "Fout Melding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }else {
                conn.OpenConn();
                // Check if klant in DB exist by document ID.
                    
                if (cmd != 1) {
                    label.Text = cmd.ToString();
                    //Toevoegen();
                    MessageBox.Show("De klant is met succes toegevoegd.", "Met Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return 1;
                }
                else {
                    label.Text = cmd.ToString();
                    MessageBox.Show("De klant bestaat al.", "Fout Melding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return 0;
            }

            }

        }


    }
}