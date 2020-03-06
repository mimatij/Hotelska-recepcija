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
    public partial class Dodaj_izmjeni_zaposlenika : Form
    {
        string connectionstring;
        SqlConnection connection;        
        public Dodaj_izmjeni_zaposlenika()
        {
            InitializeComponent();
            //connectionstring = ConfigurationManager.ConnectionStrings["Hotel.Properties.Settings.HotelConnectionString"].ConnectionString;
            connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mia\Desktop\Faks\RACUNARSTVO 2019_2020\RP3\Projekt\Hotel\Hotel.mdf;Integrated Security=True";
            Dodaj.Visible = true;
            Spremi_promjene.Visible = false;
        }
        public Dodaj_izmjeni_zaposlenika(string ime, string prezime, string OIB, string datum_rod, string mob, string email, string zanimanje)
        {
            InitializeComponent();
            //connectionstring = ConfigurationManager.ConnectionStrings["Hotel.Properties.Settings.HotelConnectionString"].ConnectionString;
            connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mia\Desktop\Faks\RACUNARSTVO 2019_2020\RP3\Projekt\Hotel\Hotel.mdf;Integrated Security=True";

            Dodaj.Visible = false;
            Spremi_promjene.Visible = true;

            textBox1.Text = ime;
            textBox1.ForeColor = Color.Silver;
            textBox2.Text = prezime;
            textBox2.ForeColor = Color.Silver;
            maskedTextBox1.Text = OIB;
            maskedTextBox1.ForeColor = Color.Silver;
            maskedTextBox2.Text = mob;
            maskedTextBox2.ForeColor = Color.Silver;
            maskedTextBox3.Text = datum_rod;
            maskedTextBox3.ForeColor = Color.Silver;
            textBox5.Text = email;
            textBox5.ForeColor = Color.Silver;
            textBox6.Text = zanimanje;
            textBox6.ForeColor = Color.Silver;
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(maskedTextBox1.Text)
                && !String.IsNullOrEmpty(textBox1.Text)
                && !String.IsNullOrEmpty(textBox2.Text)
                && !String.IsNullOrEmpty(maskedTextBox3.Text)
                && !String.IsNullOrEmpty(maskedTextBox2.Text)
                && !String.IsNullOrEmpty(textBox5.Text)
                && !String.IsNullOrEmpty(textBox6.Text)) 
            {
                string query = "INSERT INTO OSOBLJE VALUES (@OIB,@Ime,@Prezime,@Datum_rod,@Mobitel,@Email,@Zanimanje)";

                using (connection = new SqlConnection(connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@OIB", Int64.Parse(maskedTextBox1.Text));
                    command.Parameters.AddWithValue("@Ime", textBox1.Text);
                    command.Parameters.AddWithValue("@Prezime", textBox2.Text);
                    command.Parameters.AddWithValue("@Datum_rod", DateTime.Parse(maskedTextBox3.Text));
                    command.Parameters.AddWithValue("@Mobitel", maskedTextBox2.Text);
                    command.Parameters.AddWithValue("@Email", textBox5.Text);
                    command.Parameters.AddWithValue("@Zanimanje", textBox6.Text);

                    MessageBox.Show("Broj row: " + command.ExecuteNonQuery());
                    connection.Close();
                }

                Popis_osoblja forma3 = new Popis_osoblja();
                forma3.Show();
                this.Close();
            }
            else
                MessageBox.Show("Nije sve popunjeno!");
        }

        private void Spremi_promjene_Click(object sender, EventArgs e)
        {
            string query = "UPDATE OSOBLJE SET Ime=@Ime,Prezime=@Prezime,Datum_rod=@Datum_rod,Mobitel=@Mobitel,Email=@Email,Zanimanje=@Zanimanje WHERE OIB=@OIB";

            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@OIB", maskedTextBox1.Text);
                command.Parameters.AddWithValue("@Ime", textBox1.Text);
                command.Parameters.AddWithValue("@Prezime", textBox2.Text);
                command.Parameters.AddWithValue("@Datum_rod", DateTime.Parse(maskedTextBox3.Text));
                command.Parameters.AddWithValue("@Mobitel", maskedTextBox2.Text);
                command.Parameters.AddWithValue("@Email", textBox5.Text);
                command.Parameters.AddWithValue("@Zanimanje", textBox6.Text);

                command.ExecuteScalar();
            }

            Popis_osoblja forma3 = new Popis_osoblja();
            forma3.Show();
            this.Close();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
        }
       

        private void maskedTextBox1_Enter(object sender, EventArgs e)
        {
            maskedTextBox1.ForeColor = Color.Black;
        }

        private void maskedTextBox2_Enter(object sender, EventArgs e)
        {
            maskedTextBox2.ForeColor = Color.Black;
        }

        private void maskedTextBox3_Enter(object sender, EventArgs e)
        {
            maskedTextBox3.ForeColor = Color.Black;
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            textBox5.ForeColor = Color.Black;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.Black;
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            textBox6.ForeColor = Color.Black;
        }

        private void Dodaj_izmjeni_zaposlenika_Load(object sender, EventArgs e)
        {

        }
    }
}
