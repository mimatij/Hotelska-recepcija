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
using System.Globalization;

namespace Hotel
{
    public partial class FormIzmijeniRezervacijuUsluge : Form
    {
        string connectionstring;
        SqlConnection connection;

        string id_rez;
        string id_usluge;
        string datum;
        string gost_ime;
        string gost_prezime;
        string gost_oib;
        string placeno;

        public FormIzmijeniRezervacijuUsluge(string id_rez2, string id_usluge2, string datum2,
                                        string gost_ime2, string gost_prezime2,
                                        string gost_oib2, string placeno2)
        {
            id_rez = id_rez2;
            id_usluge = id_usluge2;
            datum = datum2;
            gost_ime = gost_ime2;
            gost_prezime = gost_prezime2;
            gost_oib = gost_oib2;
            placeno = placeno2;

            InitializeComponent();
            connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mia\Desktop\Faks\RACUNARSTVO 2019_2020\RP3\Projekt\Hotel\Hotel.mdf;Integrated Security=True";

            tb_idrez.Text = id_rez;
            tb_idsobe.Text = id_usluge;
            date_do.Value = DateTime.Parse(datum);
            tb_gostime.Text = gost_ime;
            tb_gostprezime.Text = gost_prezime;
            tb_gostoib.Text = gost_oib;
            tb_placeno.Text = placeno;

            date_do.Format = DateTimePickerFormat.Custom;
            date_do.CustomFormat = "dd/MM/yyyy HH:mm:ss";
        }

        public FormIzmijeniRezervacijuUsluge()
        {
            InitializeComponent();
            connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mia\Desktop\Faks\RACUNARSTVO 2019_2020\RP3\Projekt\Hotel\Hotel.mdf;Integrated Security=True";

            date_do.Format = DateTimePickerFormat.Custom;
            date_do.CustomFormat = "dd/MM/yyyy HH:mm:ss";
        }

        private void btn_okizmijeni_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tb_idrez.Text)
                && !String.IsNullOrEmpty(tb_idsobe.Text)
                && !String.IsNullOrEmpty(tb_placeno.Text)
                && !String.IsNullOrEmpty(tb_gostime.Text)
                && !String.IsNullOrEmpty(tb_gostprezime.Text)
                && !String.IsNullOrEmpty(tb_gostoib.Text))
            {
                string query = "UPDATE REZERVACIJE_USLUGA SET Id_usluge=@id_usluge,Datum=@datum,Gost_ime=@gost_ime,Gost_prezime=@gost_prezime,Gost_oib=@gost_oib,Placeno=@placeno WHERE Id_rezervacije=@id_rez";

                using (connection = new SqlConnection(connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    string placeno;
                    if (tb_placeno.Text.ToLower() == "da") placeno = "True";
                    else placeno = "False";

                    command.Parameters.AddWithValue("@id_rez", tb_idrez.Text);
                    command.Parameters.AddWithValue("@id_usluge", tb_idsobe.Text);
                    command.Parameters.AddWithValue("@datum", DateTime.Parse(date_do.Text));
                    command.Parameters.AddWithValue("@gost_ime", tb_gostime.Text);
                    command.Parameters.AddWithValue("@gost_prezime", tb_gostprezime.Text);
                    command.Parameters.AddWithValue("@gost_oib", tb_gostoib.Text);
                    command.Parameters.AddWithValue("@placeno", placeno);

                    command.ExecuteScalar();
                }

                FormPopisRezervacijaUsluga natrag = new FormPopisRezervacijaUsluga();
                natrag.Show();
                this.Close();
            }
            else
                MessageBox.Show("Nije sve popunjeno!");
        }
            
    }
}
