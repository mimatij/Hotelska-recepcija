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
    public partial class FormRezervirajUslugu : Form
    {
        string connectionstring;
        SqlConnection connection;

        public FormRezervirajUslugu()
        {
            InitializeComponent();
            connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mia\Desktop\Faks\RACUNARSTVO 2019_2020\RP3\Projekt\Hotel\Hotel.mdf;Integrated Security=True";

        }

        private void FormRezervirajUslugu_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionstring);
                connection.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.ExitThread();
            }

            SqlCommand cmd1 = new SqlCommand("SELECT Ime_usluge FROM USLUGE", connection);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd1);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                    cb_usluga.Items.Add(dr["Ime_usluge"].ToString());

                if (cb_usluga.Items.Count > 0)
                    cb_usluga.SelectedItem = cb_usluga.Items[0];
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_tipusluge.SelectedIndex != -1)
            {
                try
                {
                    connection = new SqlConnection(connectionstring);
                    connection.Open();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.ExitThread();
                }

                cb_usluga.Items.Clear();
                cb_usluga.Text = "";

                string tipUsluge = cb_tipusluge.SelectedItem.ToString();
                Console.WriteLine(tipUsluge);

                SqlCommand cmd = new SqlCommand("SELECT Id_usluge,Ime_usluge FROM USLUGE WHERE Tip_usluge='" + tipUsluge + "'", connection);

                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    foreach (DataRow dr in dt.Rows)
                        cb_usluga.Items.Add(dr["Ime_usluge"].ToString());

                    if(cb_usluga.Items.Count > 0)
                        cb_usluga.SelectedItem = cb_usluga.Items[0];
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_okRezervirajUslugu_Click(object sender, EventArgs e)
        {
            //Nađi ID usluge.
            string ID_usluge = "";
            if (cb_usluga.SelectedIndex != -1)
            {
                try
                {
                    connection = new SqlConnection(connectionstring);
                    connection.Open();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.ExitThread();
                }

                SqlCommand cmd = new SqlCommand("SELECT Id_usluge,Ime_usluge FROM USLUGE", connection);

                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    foreach (DataRow dr in dt.Rows)
                        if (dr["Ime_usluge"].ToString() == cb_usluga.SelectedItem.ToString())
                            ID_usluge = dr["Id_usluge"].ToString();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Unesite uslugu za koju želite rezervirati termin.","Nije unesena usluga",MessageBoxButtons.OK, MessageBoxIcon.Error);

            // Provjeri jesu li sva polja ispunjena.
            if (tb_gostimeusluga.Text == "" || tb_gostprezimeusluga.Text == "" || tb_gostoibusluga.Text == "")
                MessageBox.Show("Sva polja moraju biti popunjena (osim tipa usluge).", "Prazna polja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                // Izvrši INSERT.
                string query = "INSERT INTO REZERVACIJE_USLUGA VALUES (@id_usluge, @datum_vrijeme, @gost_ime, @gost_prezime, @gost_oib, @placeno)";

                using (connection = new SqlConnection(connectionstring))
                {
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        // Oblikuj datum i vrijeme.
                        DateTime datumIVrijeme = DateTime.ParseExact(date_usluga.Text, "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
                        Console.WriteLine(datumIVrijeme);

                        // Unesi parametre.
                        connection.Open();
                        cmd.Parameters.AddWithValue("@id_usluge", ID_usluge);
                        cmd.Parameters.AddWithValue("@datum_vrijeme", datumIVrijeme);
                        cmd.Parameters.AddWithValue("@gost_ime", tb_gostimeusluga.Text);
                        cmd.Parameters.AddWithValue("@gost_prezime", tb_gostprezimeusluga.Text);
                        cmd.Parameters.AddWithValue("@gost_oib", tb_gostoibusluga.Text);
                        cmd.Parameters.AddWithValue("@placeno", "false");
                        //cmd.ExecuteScalar();
                        cmd.ExecuteNonQuery();

                    }
                }
                FormPopisUsluga natrag = new FormPopisUsluga();
                natrag.Show();
                this.Close();
            }         
        }
    }
}
