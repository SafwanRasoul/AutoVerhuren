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
    public partial class Reserveren : Form {
        int res_id, auto_id, klant_id;
        DateTime res_datum, eind_datum;
        bool status;
        Classes.ClsReserverenQuery clsReserverenQuery = new Classes.ClsReserverenQuery();
        Classes.DbConnection conn = new Classes.DbConnection();

        public Reserveren() {
            conn.OpenConn();
            InitializeComponent();
        }

        private void reserverenBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.reserverenBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autosVerhurenDataSet);

        }


        private void Reserveren_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'autosVerhurenDataSet.reserveren' table. You can move, or remove it, as needed.
            //
            /*
            chkActieveRes.Checked = true;
            if (chkActieveRes.Checked) {
                this.reserverenTableAdapter.FillResByStatus(this.autosVerhurenDataSet.reserveren);
            } else {
                this.reserverenTableAdapter.Fill(this.autosVerhurenDataSet.reserveren);
            }

            // Proberen om Klanten namen en Auto's modellen uit db te halen en in Dropdown uitprinten.
            
            try {

                SqlCommand command = new SqlCommand();
                command.Connection = conn.OpenConn();
                string selectKlantQuery = "SELECT klant_id, naam FROM klant";
                command.CommandText = selectKlantQuery;

                SqlDataReader readerKlant = command.ExecuteReader();
                while (readerKlant.Read()) {
                    comboKlant.Items.Add(readerKlant[1].ToString());
                }
                readerKlant.Close();

                //Auto
                string selectAutoQuery = "SELECT auto_id, model FROM auto";
                command.CommandText = selectAutoQuery;

                SqlDataReader readerAuto = command.ExecuteReader();
                while (readerAuto.Read()) {
                    comboAuto.Items.Add(readerAuto[1].ToString());
                }
                readerAuto.Close();


            } catch (Exception ex){
                MessageBox.Show("Error " + ex);
            }
            */


        }


        //Toevoegen Button
        private void btnReserveerToevoegen_Click(object sender, EventArgs e) {
            int res = clsReserverenQuery.CheckReserverenIfExist(txtResId.Text);

            // Controleren if Reservering ID in DB not exist.
            if (res == 0) {
                Toevoegen();
                MessageBox.Show("De auto is gereserveerd.", "Met Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else {
                MessageBox.Show("Sorry, de auto is al gereserveerd.", "Fout Melding", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Wijzigen Button
        private void btnReserveerWijzigen_Click_1(object sender, EventArgs e) {
            conn.OpenConn();
            Wijzigen();
            this.reserverenTableAdapter.Fill(this.autosVerhurenDataSet.reserveren);
            this.reserverenTableAdapter.Fill(this.autosVerhurenDataSet.reserveren);
            conn.OpenConn().Close();
        }

        //Search Reservering By Klant naam.
        private void SearchByKlantNaam_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                //If Document ID TextBox is empty or White space
                if (string.IsNullOrWhiteSpace(SearchByKlantNaam.Text)) {
                    MessageBox.Show("Zoekbalk is leeg.", "Fout Melding", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else {
                    this.reserverenTableAdapter.SearchByRes_id(this.autosVerhurenDataSet.reserveren, Convert.ToInt32(txtResId.Text));
                    e.Handled = true;

                }
            }
        }

        //Actieve Reserveringen CheckBox 
        private void chkActieveRes_CheckedChanged(object sender, EventArgs e) {
            if (chkActieveRes.Checked) {
                this.reserverenTableAdapter.FillResByStatus(this.autosVerhurenDataSet.reserveren);
            } else {
                this.reserverenTableAdapter.Fill(this.autosVerhurenDataSet.reserveren);
            }
        }

        //Nieuwe Reservering Button
        private void AddRes_Click(object sender, EventArgs e) {
            AddAuto();
        }


        //Toevoegen Method
        public void Toevoegen() {
            //initialize
            klant_id = clsReserverenQuery.SelectKlantId(comboKlant.SelectedItem.ToString());
            auto_id = clsReserverenQuery.SelectAutoId(comboAuto.SelectedItem.ToString());
            res_datum = Convert.ToDateTime(tmResDatum.Value);
            eind_datum = Convert.ToDateTime(tmEindDatum.Value);
            status = chkResBox.Checked;

            this.reserverenTableAdapter.Insert(auto_id, klant_id, res_datum, eind_datum, status);
            clsReserverenQuery.insert(auto_id, klant_id, res_datum, eind_datum, status);

            this.reserverenTableAdapter.Fill(this.autosVerhurenDataSet.reserveren);
        }


        private void button1_Click(object sender, EventArgs e) {
            res_datum = tmResDatum.Value.Date;
            label3.Text = res_datum.ToString();
        }


        //Wijzigen Method
        public void Wijzigen() {
            //initialize
            res_id = Convert.ToInt32(txtResId.Text);
            auto_id = Convert.ToInt32(comboAuto.SelectedValue);
            klant_id = Convert.ToInt32(comboKlant.SelectedValue);
            res_datum = tmResDatum.Value;
            eind_datum = tmEindDatum.Value;
            status = chkResBox.Checked;

            clsReserverenQuery.Wijzigen(auto_id, klant_id, res_datum, eind_datum, status, res_id);
            //this.reserverenTableAdapter.Update(this.autosVerhurenDataSet.reserveren);
            
            this.reserverenTableAdapter.Fill(this.autosVerhurenDataSet.reserveren);

        }


        //Verwijderen Method
        public void Verwijderen() {
            //initialize
            res_id = Convert.ToInt32(txtResId.Text);
            auto_id = Convert.ToInt32(comboAuto.SelectedValue);
            klant_id = Convert.ToInt32(comboKlant.SelectedValue);
            res_datum = tmResDatum.Value;
            eind_datum = tmEindDatum.Value;
            status = chkResBox.Checked;

            //this.klantTableAdapter.Delete(naam, achternaam, adres, huis_nr, postcode, woonplaats);
        }


        //Nieuwe Reservering
        public void AddAuto() {
            //initialize
            txtResId.Text = "";
            chkResBox.Checked = false;
            this.ActiveControl = comboKlant;
        }


    }
}
