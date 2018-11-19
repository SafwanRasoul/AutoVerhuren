using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AutoVerhuren {
    
    public partial class Autos : Form {
        string merk, model, kleur, brandstof, kenteken;
        int huurprijs, bouwjaar;
        bool status;
        Classes.ClsAutoQuery clsAutoQuery = new Classes.ClsAutoQuery();
        Classes.DbConnection _conn = new Classes.DbConnection();

        public Autos() {
            InitializeComponent();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e) {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e) {

        }


        private void autoDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }


        private void autoBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.autoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autosVerhurenDataSet);
            this.autoTableAdapter.Fill(this.autosVerhurenDataSet.auto);

        }

        //Toevoegen
        private void btnAutoToevoegen_Click_1(object sender, EventArgs e) {
            int res = clsAutoQuery.CheckKentekenIfExist(txtKenteken.Text);

            if (res == 0) {
                Toevoegen();
                MessageBox.Show("De auto is met succes toegevoegd.", "Met Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtKenteken.Enabled = false;
            } else {
                MessageBox.Show("De auto betaat al.", "Fout Melding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Wijzigen
        private void btnAutoWijzigen_Click_1(object sender, EventArgs e) {
            Wijzigen();
        }

        private void chkActieveKlanten_CheckedChanged(object sender, EventArgs e) {
            if (chkActieveAutos.Checked) {
                this.autoTableAdapter.FillByAutos(this.autosVerhurenDataSet.auto);
            } else {
                this.autoTableAdapter.Fill(this.autosVerhurenDataSet.auto);
            }
        }


        /*
        //Verwijderen
        private void btnAutoVerwijderen_Click(object sender, EventArgs e) {
            
            if (MessageBox.Show("Weet u zeker dat u deze auto wilt verwijderen?", "Bevestigen", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                clsAutoQuery.delete(txtKenteken.Text);
                this.autoTableAdapter.Fill(this.autosVerhurenDataSet.auto);
            }

        }
        */

        private void btnAddAuto_Click(object sender, EventArgs e) {
            AddAuto();
        }


        private void Autos_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'autosVerhurenDataSet.klant' table. You can move, or remove it, as needed.
            this.autoTableAdapter.Fill(this.autosVerhurenDataSet.auto);
            // TODO: This line of code loads data into the 'autosVerhurenDataSet.klant' table. You can move, or remove it, as needed.
            this.autoTableAdapter.Fill(this.autosVerhurenDataSet.auto);
            // TODO: This line of code loads data into the 'autosVerhurenDataSet.auto' table. You can move, or remove it, as needed.
            chkActieveAutos.Checked = true;
            if (chkActieveAutos.Checked) {
                this.autoTableAdapter.FillByAutos(this.autosVerhurenDataSet.auto);
            } else {
                this.autoTableAdapter.Fill(this.autosVerhurenDataSet.auto);
            }

        }


        

        public void Toevoegen() {
            //initialize
            merk = txtMerk.Text.ToString();
            model = txtModel.Text.ToString();
            bouwjaar = Convert.ToInt32(txtHuurPrijs.Text);
            kleur = txtKleur.Text.ToString();
            brandstof = txtBrandstof.Text.ToString();
            huurprijs = Convert.ToInt32(txtBouwjaar.Text);
            kenteken = txtKenteken.Text.ToString();
            status = chkAutoBox.Checked;

            this.autoTableAdapter.Insert(merk, model, bouwjaar, kleur, brandstof, huurprijs, kenteken, status);
            clsAutoQuery.insert(merk, model, bouwjaar, kleur, brandstof, huurprijs, kenteken, status);

            if (chkActieveAutos.Checked) {
                this.autoTableAdapter.FillByAutos(this.autosVerhurenDataSet.auto);
            } else {
                this.autoTableAdapter.Fill(this.autosVerhurenDataSet.auto);
            }

            /*
            try {
                if (_conn.Connect.State == ConnectionState.Closed)
                    _conn.conString();

                SqlCommand sqlCmd = new SqlCommand("AddAuto", _conn.Connect);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@mode", "Add");
                sqlCmd.Parameters.AddWithValue("@merk", txt);
                sqlCmd.Parameters.AddWithValue("@model", txtName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@bouwjaar", txtMobileNumber.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@kleur", txtAddress.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@brandstof", txtName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@huurprijs", txtName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@status", txtName.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Saved successfully");

                SqlCommand sqlCmd = new SqlCommand("ContactAddOrEdit", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@mode", "Edit");
                sqlCmd.Parameters.AddWithValue("@ContactId", ContactId);
                sqlCmd.Parameters.AddWithValue("@Name", txtName.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@MobileNumber", txtMobileNumber.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@Address", txtAddress.Text.Trim());
                sqlCmd.ExecuteNonQuery();
                MessageBox.Show("Updated successfully");

                Reset();
                FillDataGridView();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message, "Error Message");
            }
            finally {
                sqlCon.Close();
            }
            */

        }



        public void Wijzigen() {
            //initialize
            merk = txtMerk.Text.ToString();
            model = txtModel.Text.ToString();
            bouwjaar = Convert.ToInt32(txtHuurPrijs.Text);
            kleur = txtKleur.Text.ToString();
            brandstof = txtBrandstof.Text.ToString();
            huurprijs = Convert.ToInt32(txtBouwjaar.Text);
            kenteken = txtKenteken.Text.ToString();
            status = chkAutoBox.Checked;

            this.autoTableAdapter.UpdateQuery(merk, model, bouwjaar, kleur, brandstof, huurprijs, kenteken, status, kenteken);
            clsAutoQuery.wijzigen(merk, model, bouwjaar, kleur, brandstof, huurprijs, kenteken, status, kenteken);

            if (chkActieveAutos.Checked) {
                this.autoTableAdapter.FillByAutos(this.autosVerhurenDataSet.auto);
            } else {
                this.autoTableAdapter.Fill(this.autosVerhurenDataSet.auto);
            }

        }


        /*
        public void Verwijderen() {
            //initialize
            merk = txtMerk.Text.ToString();
            model = txtModel.Text.ToString();
            bouwjaar = Convert.ToInt32(txtHuurPrijs.Text);
            kleur = txtKleur.Text.ToString();
            brandstof = txtBrandstof.Text.ToString();
            huurprijs = Convert.ToInt32(txtBouwjaar.Text);
            kenteken = txtKenteken.Text.ToString();
            status = chkAutoBox.Checked;


            this.autoTableAdapter.DeleteQuery(kenteken);
            clsAutoQuery.delete(kenteken);
            this.autoTableAdapter.Fill(this.autosVerhurenDataSet.auto);
        }
        */

        public void AddAuto() {
            //initialize
            txtMerk.Text = "";
            txtModel.Text = "";
            txtHuurPrijs.Text = "";
            txtKleur.Text = "";
            txtBrandstof.Text = "";
            txtBouwjaar.Text = "";
            txtKenteken.Text = "";
            chkAutoBox.Checked = false;
            txtKenteken.Enabled = true;
            this.ActiveControl = txtMerk;
        }


    }
}
