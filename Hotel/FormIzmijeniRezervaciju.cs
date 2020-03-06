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
    public partial class FormIzmijeniRezervaciju : Form
    {
        string connectionstring;
        SqlConnection connection;

        string id_rez;
        string id_sobe;
        string datum_od;
        string datum_do;
        string gost_ime;
        string gost_prezime;
        string gost_oib;
        string placeno;

        public FormIzmijeniRezervaciju(string id_rez2, string id_sobe2, string datum_od2, 
                                        string datum_do2, string gost_ime2, string gost_prezime2, 
                                        string gost_oib2, string placeno2)
        {
            id_rez = id_rez2;
            id_sobe = id_sobe2;
            datum_od = datum_od2;
            datum_do = datum_do2;
            gost_ime = gost_ime2;
            gost_prezime = gost_prezime2;
            gost_oib = gost_oib2;
            placeno = placeno2;

            InitializeComponent();
            connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mia\Desktop\Faks\RACUNARSTVO 2019_2020\RP3\Projekt\Hotel\Hotel.mdf;Integrated Security=True";

            tb_idrez.Text = id_rez;
            tb_idsobe.Text = id_sobe;
            date_od.Value = DateTime.Parse(datum_od);
            date_do.Value = DateTime.Parse(datum_do);
            tb_gostime.Text = gost_ime;
            tb_gostprezime.Text = gost_prezime;
            tb_gostoib.Text = gost_oib;
            tb_placeno.Text = placeno;
        }

        public FormIzmijeniRezervaciju()
        {
            InitializeComponent();
            connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mia\Desktop\Faks\RACUNARSTVO 2019_2020\RP3\Projekt\Hotel\Hotel.mdf;Integrated Security=True";

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
                string query = "UPDATE REZERVACIJE_SOBA SET Id_sobe=@id_sobe,Datum_od=@datum_od,Datum_do=@datum_do,Gost_ime=@gost_ime,Gost_prezime=@gost_prezime,Gost_oib=@gost_oib,Placeno=@placeno WHERE Id_rezervacije=@id_rez";

                using (connection = new SqlConnection(connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    string placeno;
                    if (tb_placeno.Text.ToLower() == "da") placeno = "True";
                    else placeno = "False";

                    command.Parameters.AddWithValue("@id_rez", tb_idrez.Text);
                    command.Parameters.AddWithValue("@id_sobe", tb_idsobe.Text);
                    command.Parameters.AddWithValue("@datum_od", DateTime.Parse(date_od.Text));
                    command.Parameters.AddWithValue("@datum_do", DateTime.Parse(date_do.Text));
                    command.Parameters.AddWithValue("@gost_ime", tb_gostime.Text);
                    command.Parameters.AddWithValue("@gost_prezime", tb_gostprezime.Text);
                    command.Parameters.AddWithValue("@gost_oib", tb_gostoib.Text);
                    command.Parameters.AddWithValue("@placeno", placeno);

                    command.ExecuteScalar();
                }

                FormPopisRezervacijaSobaPocetno natrag = new FormPopisRezervacijaSobaPocetno();
                natrag.Show();
                this.Close();
            }

            else
            {
                MessageBox.Show("Nije sve popunjeno!");
            }
        }

        private void FormIzmijeniRezervaciju_Load(object sender, EventArgs e)
        {

        }
    }
}
