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
    public partial class FormOpisIRezervacijaSobaRezerviraj : Form
    {
        string ID_sobe; 
        DateTime Datum_od, Datum_do;
        string connectionstring;
        SqlConnection connection;

        public FormOpisIRezervacijaSobaRezerviraj(string id, DateTime datum_od, DateTime datum_do)
        {
            Console.WriteLine("tu");
            ID_sobe = id; Datum_od = datum_od; Datum_do = datum_do;
            //connectionstring = ConfigurationManager.ConnectionStrings["Hotel.Properties.Settings.HotelConnectionString"].ConnectionString;
            connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mia\Desktop\Faks\RACUNARSTVO 2019_2020\RP3\Projekt\Hotel\Hotel.mdf;Integrated Security=True";
            InitializeComponent();
        }

        private void FormOpisIRezervacijaSobaRezerviraj_Load(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tb_gostime.Text) 
                && !String.IsNullOrEmpty(tb_gostprezime.Text) 
                && !String.IsNullOrEmpty(tb_gostoib.Text))
            {
                //string query = "INSERT INTO REZERVACIJE_SOBA (Id_sobe, Datum_od, Datum_do, Gost_ime, Gost_prezime, Gost_OIB, Placeno) VALUES (@ID_sobe, @datum_od, @datum_do, @gost_ime, @gost_prezime, @gost_oib, @placeno)";
                string query = "INSERT INTO REZERVACIJE_SOBA VALUES (@ID_sobe, @datum_od, @datum_do, @gost_ime, @gost_prezime, @gost_oib, @placeno)";

                using (connection = new SqlConnection(connectionstring))
                {
                    using(SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        connection.Open();
                        cmd.Parameters.AddWithValue("@ID_sobe", ID_sobe);
                        cmd.Parameters.AddWithValue("@datum_od", Datum_od);
                        cmd.Parameters.AddWithValue("@datum_do", Datum_do);
                        cmd.Parameters.AddWithValue("@gost_ime", tb_gostime.Text);
                        cmd.Parameters.AddWithValue("@gost_prezime", tb_gostprezime.Text);
                        cmd.Parameters.AddWithValue("@gost_oib", tb_gostoib.Text);
                        cmd.Parameters.AddWithValue("@placeno", "false");
                        //cmd.ExecuteScalar();
                        cmd.ExecuteNonQuery();

                    }
                }
                FormOpisIRezervacijaSobaPocetno natrag = new FormOpisIRezervacijaSobaPocetno();
                natrag.Show();
                this.Close();
            }

            else
            {
                MessageBox.Show("Nije sve popunjeno!");
            }          
        }
    }
}
