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
    public partial class Racun_sobe : Form
    {
        public static int broj_rezervacije;
        decimal suma = 0,suma2 = 0;
        string connectionstring;
        SqlConnection connection;
        public Racun_sobe()
        {
            InitializeComponent();
            connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mia\Desktop\Faks\RACUNARSTVO 2019_2020\RP3\Projekt\Hotel\Hotel.mdf;Integrated Security=True";
        }
        private void Ispis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ispis...");
            suma = 0;
            suma2 = 0;
            Racun1.Items.Clear();
            Racun2.Items.Clear();           
            Ukupna_cijena.Text = " " + "kn";
        }
        private void Izdaj_racun_Click(object sender, EventArgs e)
        {
            try { broj_rezervacije = Int32.Parse(textBox1.Text); }
            catch { MessageBox.Show("Krivi unos!");}

            if (Usluga_nocenja.Checked)
            {
                Rezervacija_sobe();
                Racun1.Visible = true;
                Racun2.Visible = false;
            }
            else if (Ostale_usluge.Checked)
            {
                Rezervacija_usluge();
                Racun2.Visible = true;
                Racun1.Visible = false;
            }

            panel1.Visible = true;            
            Ispis.Visible = true;
            label1.Visible = true;
            Ukupna_cijena.Visible = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { 
            Izdaj_racun.Enabled = true;
        }

        private void Rezervacija_sobe()
        {
            int broj_nocenja=0;
            decimal cijena=0;

            string query = "SELECT r.Gost_ime,r.Gost_prezime,r.Datum_od,r.Datum_do,r.Placeno,s.Cijena,s.Id "+ 
                "FROM REZERVACIJE_SOBA r,SOBE s "+
                "WHERE r.Id_rezervacije=@Id_rezervacije AND r.Id_sobe=s.Id";

            string query2 = "UPDATE REZERVACIJE_SOBA SET Placeno='True'"+
                " WHERE Id_rezervacije=@Id_rezervacije";

            using(connection=new SqlConnection(connectionstring))
            using(SqlCommand command=new SqlCommand(query,connection))
            using(SqlDataAdapter adapter=new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@Id_rezervacije", broj_rezervacije);

                DataTable tablicarezervacije = new DataTable();
                adapter.Fill(tablicarezervacije);              

                foreach(DataRow dr in tablicarezervacije.Rows)
                {
                    if (dr["Placeno"].ToString() == "True")
                    {
                        MessageBox.Show("Račun već plaćen ili u procesu naplate!");
                        Ukupna_cijena.Text = suma.ToString() + " kn";
                    }
                    else
                    {
                        string korisnik = dr["Gost_ime"].ToString() + " " + dr["Gost_prezime"].ToString();

                        ListViewItem item = new ListViewItem(new[]{
                            korisnik,
                            dr["Datum_od"].ToString(),
                            dr["Datum_do"].ToString(),
                            dr["Cijena"].ToString(),
                            dr["Id"].ToString()
                        });

                        Racun1.Items.Add(item);

                        TimeSpan difference = Convert.ToDateTime(dr["Datum_do"]).Date - Convert.ToDateTime(dr["Datum_od"]).Date;
                        broj_nocenja = (int)difference.TotalDays;
                        cijena = Convert.ToDecimal(dr["Cijena"]);

                        suma += cijena * broj_nocenja;
                        Ukupna_cijena.Text = suma.ToString() + " kn";
                    }
                }              
            }
           using (connection = new SqlConnection(connectionstring))
           using (SqlCommand command = new SqlCommand(query2, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Id_rezervacije", broj_rezervacije);

                command.ExecuteScalar();
            }

        }

        private void Rezervacija_usluge()
        {         
            string query = "SELECT r.Gost_ime,r.Gost_prezime,r.Placeno,s.Tip_usluge,s.Cijena,s.Id_usluge " +
                "FROM REZERVACIJE_USLUGA r,USLUGE s " +
                "WHERE r.Id_rezervacije=@Id_rezervacije AND r.id_usluge=s.Id_usluge";

            string query2 = "UPDATE REZERVACIJE_USLUGA SET Placeno='True'" +
                " WHERE Id_rezervacije=@Id_rezervacije";

            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@Id_rezervacije", broj_rezervacije);

                DataTable tablicarezervacije = new DataTable();
                adapter.Fill(tablicarezervacije);

                foreach (DataRow dr in tablicarezervacije.Rows)
                {
                    if (dr["Placeno"].ToString() == "True")
                    {
                        MessageBox.Show("Račun već plaćen ili u procesu naplate!");
                        Ukupna_cijena.Text = suma2.ToString() + " kn";
                    }
                    else
                    {
                        string korisnik = dr["Gost_ime"].ToString() + " " + dr["Gost_prezime"].ToString();

                        ListViewItem item = new ListViewItem(new[]{
                            korisnik,
                            dr["Tip_usluge"].ToString(),
                            dr["Cijena"].ToString()
                        });

                        Racun2.Items.Add(item);

                        suma2 += Convert.ToDecimal(dr["Cijena"]);
                        Ukupna_cijena.Text = suma2.ToString() + " kn";
                    }
                }
            }
            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query2, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@Id_rezervacije", broj_rezervacije);

                command.ExecuteScalar();
            }

        }
        private void Usluga_nocenja_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            TraziPoRezervacijamaNocenja.Visible = true;
            TraziPoRezervacijamaUsluga.Visible = false;
        }

        private void Racun_sobe_Load(object sender, EventArgs e)
        {

        }

        private void TraziPoRezervacijamaNocenja_Click(object sender, EventArgs e)
        {
            FormPopisRezervacijaSobaPocetno sobe = new FormPopisRezervacijaSobaPocetno();
            sobe.Show();
        }

        private void TraziPoRezervacijamaUsluga_Click(object sender, EventArgs e)
        {
            FormPopisRezervacijaUsluga usluge = new FormPopisRezervacijaUsluga();
            usluge.Show();
        }

        private void Ostale_usluge_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            TraziPoRezervacijamaNocenja.Visible = false;
            TraziPoRezervacijamaUsluga.Visible = true;
        }
    }
}
