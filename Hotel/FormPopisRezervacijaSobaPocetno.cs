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
    public partial class FormPopisRezervacijaSobaPocetno : Form
    {
        string connectionstring;
        SqlConnection connection;

        public FormPopisRezervacijaSobaPocetno()
        {
            InitializeComponent();
            connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mia\Desktop\Faks\RACUNARSTVO 2019_2020\RP3\Projekt\Hotel\Hotel.mdf;Integrated Security=True"; ;
            
        }

        private void FormPopisRezervacijaSobaPocetno_Load(object sender, EventArgs e)
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

            listView1.Items.Clear();

            SqlCommand cmd = new SqlCommand("SELECT * FROM REZERVACIJE_SOBA", connection);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                listView1.View = View.Details;

                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(dr["Id_rezervacije"].ToString());

                    string placeno;
                    if (dr["Placeno"].ToString() == "True") placeno = "DA";
                    else placeno = "NE";

                    item.SubItems.Add(dr["Id_sobe"].ToString());
                    item.SubItems.Add(DateTime.Parse(dr["Datum_od"].ToString()).ToString("dd/MM/yyyy"));
                    item.SubItems.Add(DateTime.Parse(dr["Datum_do"].ToString()).ToString("dd/MM/yyyy"));
                    item.SubItems.Add(dr["Gost_ime"].ToString());
                    item.SubItems.Add(dr["Gost_prezime"].ToString());
                    item.SubItems.Add(dr["Gost_OIB"].ToString());
                    item.SubItems.Add(placeno);
                    
                    listView1.Items.Add(item);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void date_danrezervacije_ValueChanged(object sender, EventArgs e)
        {
            if (!cb_neDatum.Checked)
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

                listView1.Items.Clear();

                string query = "SELECT * FROM REZERVACIJE_SOBA";
                SqlCommand cmd = new SqlCommand(query, connection);

                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    listView1.View = View.Details;

                    foreach (DataRow dr in dt.Rows)
                    {
                        DateTime odabrani_datum = DateTime.Parse(date_danrezervacije.Text);

                        if (odabrani_datum >= DateTime.Parse(dr["Datum_od"].ToString())
                            && odabrani_datum <= DateTime.Parse(dr["Datum_do"].ToString()))
                        {

                            ListViewItem item = new ListViewItem(dr["Id_rezervacije"].ToString());

                            string placeno;
                            if (dr["Placeno"].ToString() == "True") placeno = "DA";
                            else placeno = "NE";

                            item.SubItems.Add(dr["Id_sobe"].ToString());
                            item.SubItems.Add(DateTime.Parse(dr["Datum_od"].ToString()).ToString("dd/MM/yyyy"));
                            item.SubItems.Add(DateTime.Parse(dr["Datum_do"].ToString()).ToString("dd/MM/yyyy"));
                            item.SubItems.Add(dr["Gost_ime"].ToString());
                            item.SubItems.Add(dr["Gost_prezime"].ToString());
                            item.SubItems.Add(dr["Gost_OIB"].ToString());
                            item.SubItems.Add(placeno);

                            listView1.Items.Add(item);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_otkazirez_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MessageBox.Show("Odaberi prvo što želiš otkazati!");
            }
            else
            {
                ListViewItem selectedRow = listView1.SelectedItems[0];
                string IDNumber = selectedRow.SubItems[0].Text;

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionstring))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand("DELETE FROM REZERVACIJE_SOBA WHERE Id_rezervacije = '" + IDNumber + "'", connection))
                        {
                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                    }
                }
                catch (SystemException ex)
                {
                    MessageBox.Show(string.Format("An error occurred: {0}", ex.Message));
                }


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

                listView1.Items.Clear();

                SqlCommand cmd = new SqlCommand("SELECT * FROM REZERVACIJE_SOBA", connection);

                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    listView1.View = View.Details;

                    foreach (DataRow dr in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(dr["Id_rezervacije"].ToString());

                        string placeno;
                        if (dr["Placeno"].ToString() == "True") placeno = "DA";
                        else placeno = "NE";

                        item.SubItems.Add(dr["Id_sobe"].ToString());
                        item.SubItems.Add(DateTime.Parse(dr["Datum_od"].ToString()).ToString("dd/MM/yyyy"));
                        item.SubItems.Add(DateTime.Parse(dr["Datum_do"].ToString()).ToString("dd/MM/yyyy"));
                        item.SubItems.Add(dr["Gost_ime"].ToString());
                        item.SubItems.Add(dr["Gost_prezime"].ToString());
                        item.SubItems.Add(dr["Gost_OIB"].ToString());
                        item.SubItems.Add(placeno);

                        listView1.Items.Add(item);
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_izmijenirez_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = listView1.SelectedItems[0];
                string id_rez = selectedRow.SubItems[0].Text;
                string id_sobe = selectedRow.SubItems[1].Text;
                string datum_od = selectedRow.SubItems[2].Text;
                string datum_do = selectedRow.SubItems[3].Text;
                string gost_ime = selectedRow.SubItems[4].Text;
                string gost_prezime = selectedRow.SubItems[5].Text;
                string gost_oib = selectedRow.SubItems[6].Text;
                string placeno = selectedRow.SubItems[7].Text;

                FormIzmijeniRezervaciju FormIzmijeniRezervaciju1
                    = new FormIzmijeniRezervaciju(id_rez, id_sobe, datum_od, datum_do,
                                                    gost_ime, gost_prezime, gost_oib, placeno);
                FormIzmijeniRezervaciju1.Show();
            }

            else
            {
                FormIzmijeniRezervaciju FormIzmijeniRezervaciju1 = new FormIzmijeniRezervaciju();
                FormIzmijeniRezervaciju1.Show();
            }

            this.Close();
        }

        private void cb_neDatum_CheckedChanged(object sender, EventArgs e)
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

            listView1.Items.Clear();

            SqlCommand cmd = new SqlCommand("SELECT * FROM REZERVACIJE_SOBA", connection);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                listView1.View = View.Details;

                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(dr["Id_rezervacije"].ToString());

                    string placeno;
                    if (dr["Placeno"].ToString() == "True") placeno = "DA";
                    else placeno = "NE";

                    item.SubItems.Add(dr["Id_sobe"].ToString());
                    item.SubItems.Add(DateTime.Parse(dr["Datum_od"].ToString()).ToString("dd/MM/yyyy"));
                    item.SubItems.Add(DateTime.Parse(dr["Datum_do"].ToString()).ToString("dd/MM/yyyy"));
                    item.SubItems.Add(dr["Gost_ime"].ToString());
                    item.SubItems.Add(dr["Gost_prezime"].ToString());
                    item.SubItems.Add(dr["Gost_OIB"].ToString());
                    item.SubItems.Add(placeno);

                    listView1.Items.Add(item);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    //}
}
