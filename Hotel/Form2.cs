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
    public partial class Popis_gostiju : Form
    {
        string connectionstring;
        SqlConnection connection;
        public Popis_gostiju()
        {
            InitializeComponent();
            connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mia\Desktop\Faks\RACUNARSTVO 2019_2020\RP3\Projekt\Hotel\Hotel.mdf;Integrated Security=True";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Popis();
        }

        private void Popis()
        {

            string query = "SELECT DISTINCT Gost_ime,Gost_prezime,Gost_OIB FROM REZERVACIJE_SOBA " +
                "UNION SELECT DISTINCT Gost_ime,Gost_prezime,Gost_OIB FROM REZERVACIJE_USLUGA";            

            using (connection = new SqlConnection(connectionstring))            
            using (SqlDataAdapter adapter = new SqlDataAdapter(query,connection))
            {               
                DataTable tablicagostiju = new DataTable();
                adapter.Fill(tablicagostiju);

                foreach (DataRow dr in tablicagostiju.Rows)
                {
                    ListViewItem item = new ListViewItem(new[]{                        
                        dr["Gost_ime"].ToString(),
                        dr["Gost_prezime"].ToString(),
                        dr["Gost_OIB"].ToString()
                    });

                        listView1.Items.Add(item);

                }
            }                 
        }

        private void Unos_ime_prezime_TextChanged(object sender, EventArgs e)
        {            
        }

        private void Filtar_ime_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            string query = "SELECT DISTINCT Gost_ime,Gost_prezime,Gost_OIB " +
                "FROM REZERVACIJE_SOBA WHERE Gost_ime=@Gost_ime AND Gost_prezime=@Gost_prezime "+
                "UNION SELECT DISTINCT Gost_ime,Gost_prezime,Gost_OIB " +
                "FROM REZERVACIJE_USLUGA WHERE Gost_ime=@Gost_ime AND Gost_prezime=@Gost_prezime ";


            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@Gost_ime", Unos_ime.Text);
                command.Parameters.AddWithValue("@Gost_prezime", Unos_prezime.Text);

                DataTable tablicagostiju = new DataTable();
                adapter.Fill(tablicagostiju);

                foreach (DataRow dr in tablicagostiju.Rows)
                {
                    ListViewItem item = new ListViewItem(new[]{
                        dr["Gost_ime"].ToString(),
                        dr["Gost_prezime"].ToString(),
                        dr["Gost_OIB"].ToString()
                    });

                    listView1.Items.Add(item);
                }                
            }

        }

        private void Filtar_datum_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            DateTime odabrani_datum = DateTime.Parse(dateTimePicker1.Text);
            string query = "SELECT DISTINCT Gost_ime,Gost_prezime,Gost_OIB,Datum_od,Datum_do " +
                "FROM REZERVACIJE_SOBA";


            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                DataTable tablicagostiju = new DataTable();
                adapter.Fill(tablicagostiju);

                foreach (DataRow dr in tablicagostiju.Rows)
                {
                    if (DateTime.Parse(dr["Datum_od"].ToString()) <= odabrani_datum && DateTime.Parse(dr["Datum_do"].ToString()) >= odabrani_datum)
                    {
                        ListViewItem item = new ListViewItem(new[]{
                        dr["Gost_ime"].ToString(),
                        dr["Gost_prezime"].ToString(),
                        dr["Gost_OIB"].ToString()
                    });

                        listView1.Items.Add(item);
                    }
                }
            }

        }
    }
}
