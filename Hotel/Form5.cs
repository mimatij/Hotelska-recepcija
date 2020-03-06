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
    public partial class Raspored : Form
    {
        string connectionstring;
        SqlConnection connection;
        string ime, prezime, OIBz, radi_od, radi_do, datum, zaduzenje,id;

        private void Dodaj_zaduzenje_Click(object sender, EventArgs e)
        {
            Form6 forma6 = new Form6();
            forma6.Show();
            this.Close();
        }

        private void Ukloni_zaduzenje_Click(object sender, EventArgs e)
        {
            string query1 = "DELETE FROM RASPORED WHERE Id='"+id+"'";
            

            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query1, connection))
            {
                connection.Open();
                command.ExecuteNonQuery();
            }

            listView1.Items.Clear();
            string query = "SELECT r.OIB_zaposlenika,r.Radi_od,r.Radi_do,r.Datum,r.Posao,s.Ime,s.Prezime,r.Id " +
               "FROM RASPORED r,OSOBLJE s WHERE s.OIB=r.OIB_zaposlenika";

            using (connection = new SqlConnection(connectionstring))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable raspored = new DataTable();
                adapter.Fill(raspored);

                foreach (DataRow dr in raspored.Rows)
                {
                    ListViewItem item = new ListViewItem(new[]{
                        dr["Ime"].ToString(),
                        dr["Prezime"].ToString(),
                        dr["OIB_zaposlenika"].ToString(),
                        dr["Radi_od"].ToString(),
                        dr["Radi_do"].ToString(),
                        dr["Datum"].ToString(),
                        dr["Posao"].ToString(),
                        dr["Id"].ToString()
                    });

                    listView1.Items.Add(item);

                }
            }

        }

        public Raspored()
        {
            InitializeComponent();
            connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mia\Desktop\Faks\RACUNARSTVO 2019_2020\RP3\Projekt\Hotel\Hotel.mdf;Integrated Security=True";
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Popis();
        }
        private void Popis()
        {

            string query = "SELECT r.OIB_zaposlenika,r.Radi_od,r.Radi_do,r.Datum,r.Posao,s.Ime,s.Prezime,r.Id " +
                "FROM RASPORED r,OSOBLJE s WHERE s.OIB=r.OIB_zaposlenika";

            using (connection = new SqlConnection(connectionstring))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable raspored = new DataTable();
                adapter.Fill(raspored);

                foreach (DataRow dr in raspored.Rows)
                {
                    ListViewItem item = new ListViewItem(new[]{
                        dr["Ime"].ToString(),
                        dr["Prezime"].ToString(),
                        dr["OIB_zaposlenika"].ToString(),
                        dr["Radi_od"].ToString(),
                        dr["Radi_do"].ToString(),
                        dr["Datum"].ToString(),
                        dr["Posao"].ToString(),
                        dr["Id"].ToString()
                    });

                    listView1.Items.Add(item);

                }
            }
        }

        private void Filtar_ime_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string query = "SELECT r.Id,r.OIB_zaposlenika,r.Radi_od,r.Radi_do,r.Datum,r.Posao,s.Ime,s.Prezime " +
                "FROM RASPORED r,OSOBLJE s WHERE s.OIB=r.OIB_zaposlenika AND s.Ime=@Ime AND s.Prezime=@Prezime";


            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@Ime", Unos_ime.Text);
                command.Parameters.AddWithValue("@Prezime", Unos_prezime.Text);

                DataTable raspored = new DataTable();
                adapter.Fill(raspored);

                foreach (DataRow dr in raspored.Rows)
                {
                    ListViewItem item = new ListViewItem(new[]{
                        dr["Ime"].ToString(),
                        dr["Prezime"].ToString(),
                        dr["OIB_zaposlenika"].ToString(),
                        dr["Radi_od"].ToString(),
                        dr["Radi_do"].ToString(),
                        dr["Datum"].ToString(),
                        dr["Posao"].ToString(),
                        dr["Id"].ToString()
                    });

                    listView1.Items.Add(item);
                }
            }

        }

        private void Filtar_datum_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            DateTime odabrani_datum = DateTime.Parse(dateTimePicker1.Text);
            string query = "SELECT r.Id,r.OIB_zaposlenika,r.Radi_od,r.Radi_do,r.Datum,r.Posao,s.Ime,s.Prezime " +
                "FROM RASPORED r,OSOBLJE s WHERE s.OIB=r.OIB_zaposlenika";


            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable raspored = new DataTable();
                adapter.Fill(raspored);

                foreach (DataRow dr in raspored.Rows)
                {
                    if (DateTime.Parse(dr["Datum"].ToString())==odabrani_datum){

                        ListViewItem item = new ListViewItem(new[]{
                        dr["Ime"].ToString(),
                        dr["Prezime"].ToString(),
                        dr["OIB_zaposlenika"].ToString(),
                        dr["Radi_od"].ToString(),
                        dr["Radi_do"].ToString(),
                        dr["Datum"].ToString(),
                        dr["Posao"].ToString(),
                        dr["Id"].ToString()
                    });

                        listView1.Items.Add(item);
                    }
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ime = listView1.SelectedItems[0].SubItems[0].Text;
                prezime = listView1.SelectedItems[0].SubItems[1].Text;
                OIBz = listView1.SelectedItems[0].SubItems[2].Text;
                radi_od = listView1.SelectedItems[0].SubItems[3].Text;
                radi_do = listView1.SelectedItems[0].SubItems[4].Text;
                datum = listView1.SelectedItems[0].SubItems[5].Text;
                zaduzenje = listView1.SelectedItems[0].SubItems[6].Text;
                id = listView1.SelectedItems[0].SubItems[7].Text;
            }

            Ukloni_zaduzenje.Enabled = true;
        }
    }
}
