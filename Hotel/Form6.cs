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
    public partial class Form6 : Form
    {
        string connectionstring;
        SqlConnection connection;
        string ime, prezime, OIBz;
        public Form6()
        {
            InitializeComponent();
            connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mia\Desktop\Faks\RACUNARSTVO 2019_2020\RP3\Projekt\Hotel\Hotel.mdf;Integrated Security=True";
        }

        public Form6(string ime2,string prezime2,string OIBz2)
        {
            InitializeComponent();
            connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mia\Desktop\Faks\RACUNARSTVO 2019_2020\RP3\Projekt\Hotel\Hotel.mdf;Integrated Security=True";
            textBox1.Text = ime2;
            textBox2.Text = prezime2;
            maskedTextBox1.Text = OIBz2;
        }
        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Popis_osoblja potrazi = new Popis_osoblja();
            potrazi.Show();
            this.Close();
        }

        private void Dodaj_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(maskedTextBox1.Text)               
                && !String.IsNullOrEmpty(maskedTextBox3.Text)
                && !String.IsNullOrEmpty(maskedTextBox2.Text)
                && !String.IsNullOrEmpty(textBox4.Text)
                && !String.IsNullOrEmpty(textBox6.Text))
            {
                string query = "INSERT INTO RASPORED VALUES (@OIB,@Radi_od,@Radi_do,@Datum,@Zaduzenje)";

                using (connection = new SqlConnection(connectionstring))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    command.Parameters.AddWithValue("@OIB", Int64.Parse(maskedTextBox1.Text));
                    command.Parameters.AddWithValue("@Radi_od", DateTime.Parse(maskedTextBox2.Text));
                    command.Parameters.AddWithValue("@Radi_do", DateTime.Parse(maskedTextBox3.Text));
                    command.Parameters.AddWithValue("@Datum", DateTime.Parse(textBox4.Text));
                    command.Parameters.AddWithValue("@Zaduzenje", textBox6.Text);

                    command.ExecuteScalar();
                }

                Raspored forma5 = new Raspored();
                forma5.Show();
                this.Close();
            }
            else
                MessageBox.Show("Nije sve popunjeno!");
        }
    }
}
