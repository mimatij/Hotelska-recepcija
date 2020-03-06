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
    public partial class Popis_osoblja : Form
    {
        string connectionstring;
        SqlConnection connection;
        string ime, prezime, OIBz, datum_rod, mob, email, zanimanje;

        private void Ukloni_zaposlenika_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberi prvo koga želiš ukloniti!");
            }
            else
            {
                string query1 = "DELETE FROM OSOBLJE WHERE OIB='" + OIBz + "'";


                using (connection = new SqlConnection(connectionstring))
                using (SqlCommand command = new SqlCommand(query1, connection))
                {
                    connection.Open();
                    command.ExecuteNonQuery();
                }

                listView1.Items.Clear();
                string query = "SELECT OIB,Ime,Prezime,Datum_rod,Mobitel,Email,Zanimanje FROM OSOBLJE";

                using (connection = new SqlConnection(connectionstring))
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                {
                    DataTable tablicaosoblja = new DataTable();
                    adapter.Fill(tablicaosoblja);

                    foreach (DataRow dr in tablicaosoblja.Rows)
                    {
                        ListViewItem item = new ListViewItem(new[]{
                        dr["Ime"].ToString(),
                        dr["Prezime"].ToString(),
                        dr["OIB"].ToString(),
                        dr["Datum_rod"].ToString(),
                        dr["Mobitel"].ToString(),
                        dr["Email"].ToString(),
                        dr["Zanimanje"].ToString()
                    });

                        listView1.Items.Add(item);
                    }

                }
            }            
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ime = listView1.SelectedItems[0].SubItems[0].Text;
                prezime = listView1.SelectedItems[0].SubItems[1].Text;
                OIBz = listView1.SelectedItems[0].SubItems[2].Text;                

                Izmijeni.Enabled = true;
            }
            Form6 forma6 = new Form6(ime, prezime, OIBz);
            forma6.Show();
            this.Close();


        }

        private void Izmijeni_Click(object sender, EventArgs e)
        {
            Dodaj_izmjeni_zaposlenika forma4 = new Dodaj_izmjeni_zaposlenika(ime, prezime, OIBz, datum_rod, mob, email, zanimanje);
            forma4.Text = "Izmjeni podatke zaposlenika";
            forma4.Show();
            Izmijeni.Enabled = false;
            this.Close();
        }

        public Popis_osoblja()
        {
            InitializeComponent();
            connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mia\Desktop\Faks\RACUNARSTVO 2019_2020\RP3\Projekt\Hotel\Hotel.mdf;Integrated Security=True";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Popis_zaposlenika();
        }

        private void Popis_zaposlenika()
        {

            string query = "SELECT OIB,Ime,Prezime,Datum_rod,Mobitel,Email,Zanimanje FROM OSOBLJE";

            using (connection = new SqlConnection(connectionstring))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable tablicaosoblja = new DataTable();
                adapter.Fill(tablicaosoblja);

                foreach (DataRow dr in tablicaosoblja.Rows)
                {
                    ListViewItem item = new ListViewItem(new[]{                        
                        dr["Ime"].ToString(),
                        dr["Prezime"].ToString(),
                        dr["OIB"].ToString(),
                        dr["Datum_rod"].ToString(),
                        dr["Mobitel"].ToString(),
                        dr["Email"].ToString(),
                        dr["Zanimanje"].ToString()
                    });

                    listView1.Items.Add(item); 
                }
            }
        }

        private void Dodaj_novi_Click(object sender, EventArgs e)
        {
            this.Close();
            Dodaj_izmjeni_zaposlenika forma4 = new Dodaj_izmjeni_zaposlenika();
            forma4.Text = "Dodaj novog zaposlenika";
            forma4.Show();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ime = listView1.SelectedItems[0].SubItems[0].Text;
                prezime = listView1.SelectedItems[0].SubItems[1].Text;
                OIBz = listView1.SelectedItems[0].SubItems[2].Text;
                datum_rod = listView1.SelectedItems[0].SubItems[3].Text;
                mob = listView1.SelectedItems[0].SubItems[4].Text;
                email = listView1.SelectedItems[0].SubItems[5].Text;
                zanimanje = listView1.SelectedItems[0].SubItems[6].Text;                

                Izmijeni.Enabled = true;               
            }
        }
    }
}
