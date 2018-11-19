using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoVerhuren
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            klant klant = new klant();
            klant.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(klant);
            klant.Show();
        }

        private void btnKlanten_Click(object sender, EventArgs e) {

            klant klant = new klant();
            klant.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(klant);
            klant.Show();

        }

        private void btnAutos_Click(object sender, EventArgs e) {
            Autos autos = new Autos();
            autos.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(autos);
            autos.Show();
        }

        private void btnRes_Click(object sender, EventArgs e) {
            Reserveren reserveren = new Reserveren();
            reserveren.TopLevel = false;
            content.Controls.Clear();
            content.Controls.Add(reserveren);
            reserveren.Show();
        }

    }
}
