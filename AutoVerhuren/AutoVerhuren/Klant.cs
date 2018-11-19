using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoVerhuren {
    public partial class klant : Form {
        string naam, achternaam, adres, postcode, woonplaats;
        int huis_nr, klant_id, doc_id;
        bool status;
        SqlCommand sqlCmd;
        Classes.ClsKlantenQuery clsKlantenQuery = new Classes.ClsKlantenQuery();
        Classes.DbConnection conn = new Classes.DbConnection();
        Classes.Querys querys = new Classes.Querys();

        public klant() {
            InitializeComponent();
        }

        private void klantBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.klantBindingSource1.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autosVerhurenDataSet);

        }

        private void klant_Load_1(object sender, EventArgs e) {
            //TODO: This line of code loads data into the 'autosVerhurenDataSet.klant' table. You can move, or remove it, as needed.
            chkActieveKlanten.Checked = true;
            //FillDataGridView();
            if (chkActieveKlanten.Checked) {
                this.klantTableAdapter.FillKlantenByStatus(this.autosVerhurenDataSet.klant);
            }
            else {
                this.klantTableAdapter.Fill(this.autosVerhurenDataSet.klant);
            }
        }



        //Toevoegen Button
        private void btnAddKlant_Click_1(object sender, EventArgs e) {
            ClearTextBox();
        }


        //Wijzigen
        private void btnKlantWijzigen_Click_1(object sender, EventArgs e) {
            Wijzigen();
        }

        // Klanten Status
        private void chkActieveKlanten_CheckedChanged_1(object sender, EventArgs e) {
            FillDataGridView();
        }

        //SearchBox Verlaten
        private void SearchByDocId_Leave_1(object sender, EventArgs e) {
            if (SearchByDocId.Text == "") {
                SearchByDocId.Text = "Document ID";
                SearchByDocId.ForeColor = Color.Silver;
            }
        }

        //TextBox Search Enter
        private void SearchByDocId_Enter_1(object sender, EventArgs e) {
            if (SearchByDocId.Text == "Document ID") {
                SearchByDocId.Text = "";
                SearchByDocId.ForeColor = Color.Black;
            }
        }


        //Toevoegen Button
        private void btnKlantToevoegen_Click(object sender, EventArgs e) {
            Toevoegen();
        }

        //Search Button
        private void btnZoeken_Click(object sender, EventArgs e) {
            SearchKlantByDocId();
        }


        //Toevoegen Method
        public void Toevoegen() {
            try {
                if (conn.OpenConn().State == ConnectionState.Closed)
                    conn.OpenConn();

                if (querys.CheckKlantIfExist(document_idTextBox, label1) != 0) {
                SqlCommand sqlCmd = new SqlCommand("AddKlant", conn.OpenConn());
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@mode", "Add");
                sqlCmd.Parameters.AddWithValue("@naam", naamTextBox.Text);
                sqlCmd.Parameters.AddWithValue("@achternaam", achternaamTextBox.Text);
                sqlCmd.Parameters.AddWithValue("@adres", adresTextBox.Text);
                sqlCmd.Parameters.AddWithValue("@huis_nr", huis_nrTextBox.Text);
                sqlCmd.Parameters.AddWithValue("@postcode", postcodeTextBox.Text);
                sqlCmd.Parameters.AddWithValue("@woonplaats", woonplaatsTextBox.Text);
                sqlCmd.Parameters.AddWithValue("@doc_id", document_idTextBox.Text);
                sqlCmd.Parameters.AddWithValue("@status", klant_statusCheckBox.Checked);
                sqlCmd.ExecuteNonQuery();

                FillDataGridView();
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally {
                conn.OpenConn().Close();
            }

        }

        //Wijzigen Method
        public void Wijzigen() {
            try {
                if (conn.OpenConn().State == ConnectionState.Closed)
                    conn.OpenConn();

                SqlCommand sqlCmd = new SqlCommand("AddKlant", conn.OpenConn());
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                sqlCmd.Parameters.AddWithValue("@naam", naamTextBox.Text);
                sqlCmd.Parameters.AddWithValue("@achternaam", achternaamTextBox.Text);
                sqlCmd.Parameters.AddWithValue("@adres", adresTextBox.Text);
                sqlCmd.Parameters.AddWithValue("@huis_nr", huis_nrTextBox.Text);
                sqlCmd.Parameters.AddWithValue("@postcode", postcodeTextBox.Text);
                sqlCmd.Parameters.AddWithValue("@woonplaats", woonplaatsTextBox.Text);
                sqlCmd.Parameters.AddWithValue("@doc_id", document_idTextBox.Text);
                sqlCmd.Parameters.AddWithValue("@status", klant_statusCheckBox.Checked);
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Succesvol bijgewerkt");

                FillDataGridView();
            }catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error Message");
            }finally {
                conn.OpenConn().Close();
            }
        }

        //Fill Gridview
        void FillDataGridView() {
            if (chkActieveKlanten.Checked) {
                querys.GetData("actief", klantDataGridView);
            }else {
                querys.GetData("all", klantDataGridView);
            }
        }

        //Empty all TextBoxs
        public void ClearTextBox() {
            //initialize
            klant_idTextBox.Text = "";
            naamTextBox.Text = "";
            achternaamTextBox.Text = "";
            adresTextBox.Text = "";
            huis_nrTextBox.Text = "";
            postcodeTextBox.Text = "";
            woonplaatsTextBox.Text = "";
            document_idTextBox.Text = "";
            klant_statusCheckBox.Checked = false;
            this.ActiveControl = naamTextBox;
        }

        //Klant zoeken door doc_id
        public void SearchKlantByDocId() {
            querys.GetDataByDocId(klantDataGridView, SearchByDocId, label1);
        }


    }

}

