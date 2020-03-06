using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Hotel
{
    public partial class FormPocetna : Form
    {
        public FormPocetna()
        {
            InitializeComponent();
        }

        private void opisIRezervacijaSobaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormOpisIRezervacijaSobaPocetno FormOpisIRezervacijaSobaPocetno1 = new FormOpisIRezervacijaSobaPocetno();
            FormOpisIRezervacijaSobaPocetno1.Show();
        }

        private void popisRezervacijaSobaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPopisRezervacijaSobaPocetno FormPopisRezervacijaSobaPocetno1 = new FormPopisRezervacijaSobaPocetno();
            FormPopisRezervacijaSobaPocetno1.Show();
        }

        private void popisUslugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPopisUsluga FormPopisUsluga1 = new FormPopisUsluga();
            FormPopisUsluga1.Show();
        }

        private void popisRezervacijaUslugaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPopisRezervacijaUsluga FormPopisRezervacijaUsluga1 = new FormPopisRezervacijaUsluga();
            FormPopisRezervacijaUsluga1.Show();
        }

        private void izdajRačunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Racun_sobe racun = new Racun_sobe();
            racun.Show();
        }

        private void popisOsobljaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Popis_osoblja osoblje = new Popis_osoblja();
            osoblje.Show();
        }

        private void rasporedZaduženjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Raspored raspored = new Raspored();
            raspored.Show();
        }

        private void popisGostijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Popis_gostiju gosti = new Popis_gostiju();
            gosti.Show();
        }
    }
}
