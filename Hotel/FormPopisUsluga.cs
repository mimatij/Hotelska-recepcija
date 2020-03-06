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
    public partial class FormPopisUsluga : Form
    {
        string connectionstring;
        SqlConnection connection;

        public FormPopisUsluga()
        {
            InitializeComponent();
            connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mia\Desktop\Faks\RACUNARSTVO 2019_2020\RP3\Projekt\Hotel\Hotel.mdf;Integrated Security=True";

            pnl_masaze.Visible = false;
            pnl_bazen.Visible = false;
            pnl_teretana.Visible = false;
            pnl_restoran.Visible = false;
        }

        private void btn_rezervirajUslugu_Click(object sender, EventArgs e)
        {
            FormRezervirajUslugu FormRezervirajUslugu1 = new FormRezervirajUslugu();
            FormRezervirajUslugu1.Show();

            this.Close();
        }

        private void pictureMasaze_Click(object sender, EventArgs e)
        {
            pnl_masaze.Visible = true;
            pnl_bazen.Visible = false;
            pnl_teretana.Visible = false;
            pnl_restoran.Visible = false;
        }

        private void pictureBazen_Click(object sender, EventArgs e)
        {
            pnl_masaze.Visible = false;
            pnl_bazen.Visible = true;
            pnl_teretana.Visible = false;
            pnl_restoran.Visible = false;
        }

        private void pictureTeretana_Click(object sender, EventArgs e)
        {
            pnl_masaze.Visible = false;
            pnl_bazen.Visible = false;
            pnl_teretana.Visible = true;
            pnl_restoran.Visible = false;
        }

        private void pictureRestoran_Click(object sender, EventArgs e)
        {
            pnl_masaze.Visible = false;
            pnl_bazen.Visible = false;
            pnl_teretana.Visible = false;
            pnl_restoran.Visible = true;
        }
    }
}
