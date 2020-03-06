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
    public partial class FormPopisRezervacijaUsluga : Form
    {
        string connectionstring;
        SqlConnection connection;

        public FormPopisRezervacijaUsluga()
        {
            InitializeComponent();
            connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mia\Desktop\Faks\RACUNARSTVO 2019_2020\RP3\Projekt\Hotel\Hotel.mdf;Integrated Security=True";

        }

        private void FormPopisRezervacijaUsluga_Load(object sender, EventArgs e)
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

            listView_usluge.Items.Clear();
            listView_usluge.View = View.Details;
            listView_usluge.GridLines = true;
            listView_usluge.FullRowSelect = true;
            listView_usluge.Columns[0].Width = 120;
            listView_usluge.Columns[1].Width = 60;
            listView_usluge.Columns[2].Width = 120;
            listView_usluge.Columns[3].Width = 80;
            listView_usluge.Columns[4].Width = 80;
            listView_usluge.Columns[5].Width = 80;
            listView_usluge.Columns[6].Width = 60;

            date_rezervacijausluge.Format = DateTimePickerFormat.Custom;
            date_rezervacijausluge.CustomFormat = "dd/MM/yyyy HH:mm:ss";

            date_datum.Format = DateTimePickerFormat.Custom;
            date_datum.CustomFormat = "dd/MM/yyyy";

            SqlCommand cmd = new SqlCommand("SELECT * FROM REZERVACIJE_USLUGA", connection);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(dr["Id_rezervacije"].ToString());

                    string placeno;
                    if (dr["Placeno"].ToString() == "True") placeno = "DA";
                    else placeno = "NE";

                    item.SubItems.Add(dr["id_usluge"].ToString());
                    item.SubItems.Add(DateTime.Parse(dr["Datum"].ToString()).ToString("dd/MM/yyyy HH:mm:ss"));
                    item.SubItems.Add(dr["Gost_ime"].ToString());
                    item.SubItems.Add(dr["Gost_prezime"].ToString());
                    item.SubItems.Add(dr["Gost_OIB"].ToString());
                    item.SubItems.Add(placeno);

                    listView_usluge.Items.Add(item);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void date_rezervacijausluge_ValueChanged(object sender, EventArgs e)
        {
            if (!cb_neDatumi.Checked)
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

                listView_usluge.Items.Clear();
                listView_usluge.View = View.Details;
                listView_usluge.GridLines = true;
                listView_usluge.FullRowSelect = true;

                string query = "SELECT * FROM REZERVACIJE_USLUGA";
                SqlCommand cmd = new SqlCommand(query, connection);

                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    foreach (DataRow dr in dt.Rows)
                    {
                        DateTime datumIVrijeme = DateTime.ParseExact(date_rezervacijausluge.Text, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);

                        if (datumIVrijeme == DateTime.Parse(dr["Datum"].ToString()))
                        {
                            ListViewItem item = new ListViewItem(dr["Id_rezervacije"].ToString());

                            string placeno;
                            if (dr["Placeno"].ToString() == "True") placeno = "DA";
                            else placeno = "NE";

                            item.SubItems.Add(dr["Id_usluge"].ToString());
                            item.SubItems.Add(DateTime.Parse(dr["Datum"].ToString()).ToString("dd/MM/yyyy HH:mm:ss"));
                            item.SubItems.Add(dr["Gost_ime"].ToString());
                            item.SubItems.Add(dr["Gost_prezime"].ToString());
                            item.SubItems.Add(dr["Gost_OIB"].ToString());
                            item.SubItems.Add(placeno);

                            listView_usluge.Items.Add(item);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void date_datum_ValueChanged(object sender, EventArgs e)
        {
            if (!cb_neDatumi.Checked)
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

                listView_usluge.Items.Clear();
                listView_usluge.View = View.Details;
                listView_usluge.GridLines = true;
                listView_usluge.FullRowSelect = true;

                string query = "SELECT * FROM REZERVACIJE_USLUGA";
                SqlCommand cmd = new SqlCommand(query, connection);

                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    foreach (DataRow dr in dt.Rows)
                    {
                        DateTime datumIVrijeme = DateTime.ParseExact(date_datum.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                        Console.WriteLine(datumIVrijeme.ToShortDateString());
                        Console.WriteLine(DateTime.Parse(dr["Datum"].ToString()).ToShortDateString());

                        if (datumIVrijeme.ToShortDateString() == DateTime.Parse(dr["Datum"].ToString()).ToShortDateString())
                        {
                            ListViewItem item = new ListViewItem(dr["Id_rezervacije"].ToString());

                            string placeno;
                            if (dr["Placeno"].ToString() == "True") placeno = "DA";
                            else placeno = "NE";

                            item.SubItems.Add(dr["Id_usluge"].ToString());
                            item.SubItems.Add(DateTime.Parse(dr["Datum"].ToString()).ToString("dd/MM/yyyy HH:mm:ss"));
                            item.SubItems.Add(dr["Gost_ime"].ToString());
                            item.SubItems.Add(dr["Gost_prezime"].ToString());
                            item.SubItems.Add(dr["Gost_OIB"].ToString());
                            item.SubItems.Add(placeno);

                            listView_usluge.Items.Add(item);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cb_neDatumi_CheckedChanged(object sender, EventArgs e)
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

            listView_usluge.Items.Clear();
            listView_usluge.View = View.Details;
            listView_usluge.GridLines = true;
            listView_usluge.FullRowSelect = true;

            string query = "SELECT * FROM REZERVACIJE_USLUGA";
            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(dr["Id_rezervacije"].ToString());

                    string placeno;
                    if (dr["Placeno"].ToString() == "True") placeno = "DA";
                    else placeno = "NE";

                    item.SubItems.Add(dr["Id_usluge"].ToString());
                    item.SubItems.Add(DateTime.Parse(dr["Datum"].ToString()).ToString("dd/MM/yyyy HH:mm:ss"));
                    item.SubItems.Add(dr["Gost_ime"].ToString());
                    item.SubItems.Add(dr["Gost_prezime"].ToString());
                    item.SubItems.Add(dr["Gost_OIB"].ToString());
                    item.SubItems.Add(placeno);

                    listView_usluge.Items.Add(item);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_otkazirez_Click(object sender, EventArgs e)
        {             
            if (listView_usluge.SelectedItems.Count == 0) 
            {
                MessageBox.Show("Odaberi prvo što želiš izbaciti!");
            }
            else
            {
                ListViewItem selectedRow = listView_usluge.SelectedItems[0];
                string IDNumber = selectedRow.SubItems[0].Text;

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionstring))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand("DELETE FROM REZERVACIJE_USLUGA WHERE Id_rezervacije = '" + IDNumber + "'", connection))
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

                listView_usluge.Items.Clear();

                SqlCommand cmd = new SqlCommand("SELECT * FROM REZERVACIJE_USLUGA", connection);

                try
                {
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    listView_usluge.View = View.Details;

                    foreach (DataRow dr in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(dr["Id_rezervacije"].ToString());

                        string placeno;
                        if (dr["Placeno"].ToString() == "True") placeno = "DA";
                        else placeno = "NE";

                        item.SubItems.Add(dr["Id_usluge"].ToString());
                        item.SubItems.Add(DateTime.Parse(dr["Datum"].ToString()).ToString("dd/MM/yyyy HH:mm:ss"));
                        item.SubItems.Add(dr["Gost_ime"].ToString());
                        item.SubItems.Add(dr["Gost_prezime"].ToString());
                        item.SubItems.Add(dr["Gost_OIB"].ToString());
                        item.SubItems.Add(placeno);

                        listView_usluge.Items.Add(item);
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
            if (listView_usluge.SelectedItems.Count > 0)
            {
                ListViewItem selectedRow = listView_usluge.SelectedItems[0];
                string id_rez = selectedRow.SubItems[0].Text;
                string id_usluge = selectedRow.SubItems[1].Text;
                string datum = selectedRow.SubItems[2].Text;
                string gost_ime = selectedRow.SubItems[3].Text;
                string gost_prezime = selectedRow.SubItems[4].Text;
                string gost_oib = selectedRow.SubItems[5].Text;
                string placeno = selectedRow.SubItems[6].Text;

                FormIzmijeniRezervacijuUsluge FormIzmijeniRezervacijuUsluge1
                    = new FormIzmijeniRezervacijuUsluge(id_rez, id_usluge, datum,
                                                    gost_ime, gost_prezime, gost_oib, placeno);
                FormIzmijeniRezervacijuUsluge1.Show();
            }

            else
            {
                FormIzmijeniRezervacijuUsluge FormIzmijeniRezervacijuUsluge1 = new FormIzmijeniRezervacijuUsluge();
                FormIzmijeniRezervacijuUsluge1.Show();
            }

            this.Close();
        }
    }
}
