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
    public partial class FormOpisIRezervacijaSobaPocetno : Form
    {
        string connectionstring;
        SqlConnection connection;

        public FormOpisIRezervacijaSobaPocetno()
        {
            InitializeComponent();
            //connectionstring = ConfigurationManager.ConnectionStrings["Hotel.Properties.Settings.HotelConnectionString"].ConnectionString;
            connectionstring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mia\Desktop\Faks\RACUNARSTVO 2019_2020\RP3\Projekt\Hotel\Hotel.mdf;Integrated Security=True";
        }

        private void OsobljeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            // Klikom na ikonu Save, spremi promjene u tablicu.
            this.Validate();
            this.OsobljeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDataSet);
        }

        private void FormOpisIRezervacijaSobaPocetno_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDataSet.OSOBLJE' table. You can move, or remove it, as needed.
            this.OsobljeTableAdapter.Fill(this.hotelDataSet.OSOBLJE);

            // TODO: These lines of code load data into the 'dataGridView1' table. You can move, or remove it, as needed.

            DataTable dt = new DataTable();
            //string query = "select * from SOBE where Id=@par";
            
            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("select * from SOBE", con))
                {
                    var adaptor = new SqlDataAdapter();
                    adaptor.SelectCommand = cmd;

                    con.Open();
                    adaptor.Fill(dt);

                    DataTable Result = dt;
                    SobeDataGridView.DataSource = Result;

                }
            }


            // Promijeni imena stupaca da budu ljepša i očitija.
            SobeDataGridView.Columns[0].HeaderText = "ID/broj sobe";
            SobeDataGridView.Columns[4].HeaderText = "Pogled na more";
            SobeDataGridView.Columns[9].HeaderText = "Broj kreveta";
            SobeDataGridView.Columns[10].HeaderText = "Bračni kreveti";
            SobeDataGridView.Columns[11].HeaderText = "Obični kreveti";

            // Podesi veličinu tablica.
            //tableLayoutPanel1.Width = 300;
            //tableLayoutPanel1.Location = new Point(SobeDataGridView.Width + 50, 100);
            //SobeDataGridView.Width = ClientSize.Width - 50;
            //SobeDataGridView.Height = 500;
            SobeDataGridView.Location = new Point(25, 50);
            for(int i = 0; i < 12; i++)
            {
                SobeDataGridView.Columns[i].Width = 60;
            }

            string query = "SELECT Ime " +
                "FROM OSOBLJE ";

            using (connection = new SqlConnection(connectionstring))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                //command.Parameters.AddWithValue("@Id_rezervacije", broj_rezervacije);

                DataTable tablicarezervacije = new DataTable();
                adapter.Fill(tablicarezervacije);

                foreach (DataRow dr in tablicarezervacije.Rows)
                {
                    //listBox1.Items.Add(dr["Ime"]);
                }
                
            }

           
        }
        /*
        private void printTableSobe(string query, string parameter)
        {
            DataTable dt = new DataTable();
            //string query = "select * from SOBE where Id=@par";

            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("select * from SOBE where Id=@par", con))
                {
                    int selectedrowindex = SobeDataGridView.SelectedCells[0].RowIndex;
                    //DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    //string a = Convert.ToString(selectedRow.Cells["enter column name"].Value);

                    cmd.Parameters.AddWithValue("@par", selectedrowindex + 1);

                    var adaptor = new SqlDataAdapter();
                    adaptor.SelectCommand = cmd;

                    con.Open();
                    adaptor.Fill(dt);
                    DataTable Result = dt;
                    dataGridView1.DataSource = Result;

                }
            }
        }
        */
        private void SobeDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            /*
            // TODO: These lines of code load data into the 'dataGridView1' table. You can move, or remove it, as needed.

            DataTable dt = new DataTable();
            //string query = "select * from SOBE where Id=@par";

            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                using (SqlCommand cmd = new SqlCommand("select * from SOBE where Id=@par", con))
                {
                    int selectedrowindex = SobeDataGridView.SelectedCells[0].RowIndex;
                    //DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
                    //string a = Convert.ToString(selectedRow.Cells["enter column name"].Value);

                    cmd.Parameters.AddWithValue("@par", selectedrowindex + 1);

                    var adaptor = new SqlDataAdapter();
                    adaptor.SelectCommand = cmd;

                    con.Open();
                    adaptor.Fill(dt);
                    DataTable Result = dt;
                    dataGridView1.DataSource = Result;

                }
            }
            */
        }
        
        private void btn_primijeni_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(connectionstring))
            {
                bool flag_brojsobe = false, flag_katsobe = false, flag_cijenaOd = false, 
                    flag_cijenaDo = false, flag_brojkreveta = false, 
                    flag_bracnikreveti = false, flag_obicnikreveti = false;
                Console.WriteLine("oooooooooooooooo" + date_od.Value.ToString("dd.MM.yy."));
                //Console.WriteLine("eheeeeeeeee" + Double.Parse(tb_cijenasobeDo.Text, CultureInfo.InvariantCulture));

                //string query = "select a.* from SOBE a left join REZERVACIJE_SOBA b on a.Id = b.Id_sobe" +
                //        " where (b.Id_sobe is null" +
                //        " or (b.Datum_od >= @datum_do and b.Datum_do <= @datum_od))";
                //string query = "select a.* from SOBE a left join REZERVACIJE_SOBA b on a.Id = b.Id_sobe" +
                //        " where (a.Id not in (select Id_sobe from REZERVACIJE_SOBA)" +
                //        " or (a.Id = b.Id_sobe and CAST(b.Datum_od AS DATETIME) <= CAST(@datum_do AS DATETIME))" +
                //        " or (a.Id = b.Id_sobe and CAST(b.Datum_do AS DATETIME) >= CAST(@datum_od AS DATETIME)))";


                //string query = "SELECT * FROM SOBE" +
                //" LEFT JOIN REZERVACIJE_SOBA" +
                //" ON REZERVACIJE_SOBA.Id_sobe = SOBE.Id" +
                //" AND CAST(REZERVACIJE_SOBA.Datum_do AS DATETIME) >= CAST(@datum_od AS DATETIME)" +
                //" AND CAST(REZERVACIJE_SOBA.Datum_od AS DATETIME) <= CAST(@datum_do AS DATETIME)" +
                //" WHERE REZERVACIJE_SOBA.Id_sobe IS NULL";

                string query = "SELECT * FROM SOBE" +
                " LEFT JOIN REZERVACIJE_SOBA" +
                " ON REZERVACIJE_SOBA.Id_sobe = SOBE.Id" +
                " AND CONVERT(VARCHAR, REZERVACIJE_SOBA.Datum_do, 104) >= CONVERT(VARCHAR, @datum_od, 104)" +
                " AND CONVERT(VARCHAR, REZERVACIJE_SOBA.Datum_od, 104) <= CONVERT(VARCHAR, @datum_do, 104)" +
                " WHERE REZERVACIJE_SOBA.Id_sobe IS NULL";

                int n;
                bool isNumeric = int.TryParse(tb_brojsobe.Text, out n);
                if (!String.IsNullOrEmpty(tb_brojsobe.Text) && isNumeric)
                {
                    flag_brojsobe = true;
                    query += " and SOBE.Id = @broj_sobe";
                }

                isNumeric = int.TryParse(tb_katsobe.Text, out n);
                if (!String.IsNullOrEmpty(tb_katsobe.Text) && isNumeric)
                {
                    flag_katsobe = true;
                    query += " and SOBE.Kat = @kat_sobe";
                }

                double m;
                bool isDouble = Double.TryParse(tb_cijenasobeOd.Text, out m);
                if (!String.IsNullOrEmpty(tb_cijenasobeOd.Text) /*&& isNumeric*/)
                {
                    flag_cijenaOd = true;
                    query += " and SOBE.Cijena >= @cijena_sobe_od";
                }

                isDouble = Double.TryParse(tb_cijenasobeDo.Text, out m);
                if (!String.IsNullOrEmpty(tb_cijenasobeDo.Text) /*&& isNumeric*/)
                {
                    flag_cijenaDo = true;
                    query += " and SOBE.Cijena <= @cijena_sobe_do";
                }

                if (cb_soba.Checked && !cb_apartman.Checked)
                {
                    query += " and SOBE.Apartman = 0";
                }
                else if(!cb_soba.Checked && cb_apartman.Checked)
                {
                    query += " and SOBE.Apartman = 1";
                }

                if (cb_pogledmore.Checked)
                {
                    query += " and SOBE.Pogled_na_more = 1";
                }

                if (cb_klima.Checked)
                {
                    query += " and SOBE.Klima = 1";
                }

                if (cb_tv.Checked)
                {
                    query += " and SOBE.TV = 1";
                }

                if (cb_jacuzzi.Checked)
                {
                    query += " and SOBE.Jacuzzi = 1";
                }

                if (cb_sauna.Checked)
                {
                    query += " and SOBE.Sauna = 1";
                }

                isNumeric = int.TryParse(tb_brojkreveta.Text, out n);
                if (!String.IsNullOrEmpty(tb_brojkreveta.Text) && isNumeric)
                {
                    flag_brojkreveta = true;
                    query += " and SOBE.Broj_kreveta >= @broj_kreveta";
                }

                isNumeric = int.TryParse(tb_bracnikreveti.Text, out n);
                if (!String.IsNullOrEmpty(tb_bracnikreveti.Text) && isNumeric)
                {
                    flag_bracnikreveti = true;
                    query += " and SOBE.Bracni_kreveti >= @bracni_kreveti";
                }

                isNumeric = int.TryParse(tb_obicnikreveti.Text, out n);
                if (!String.IsNullOrEmpty(tb_obicnikreveti.Text) && isNumeric)
                {
                    flag_obicnikreveti = true;
                    query += " and SOBE.Obicni_kreveti >= @obicni_kreveti";
                }

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@datum_od", DateTime.Parse(date_od.Text).ToString("dd.MM.yyyy."));
                    cmd.Parameters.AddWithValue("@datum_do", DateTime.Parse(date_do.Text).ToString("dd.MM.yyyy."));
                    Console.WriteLine(DateTime.Parse(date_od.Text).ToString("dd.MM.yyyy"));
                    Console.WriteLine(DateTime.Parse(date_do.Text).ToString("dd.MM.yyyy"));

                    if (flag_brojsobe)
                        cmd.Parameters.AddWithValue("@broj_sobe", Int32.Parse(tb_brojsobe.Text));

                    if (flag_katsobe)
                        cmd.Parameters.AddWithValue("@kat_sobe", Int32.Parse(tb_katsobe.Text));

                    if (flag_cijenaOd)
                    {
                        string pom = tb_cijenasobeOd.Text;
                        if (pom.ToLower().Contains(','))
                            cmd.Parameters.AddWithValue("@cijena_sobe_od", Double.Parse(pom, new System.Globalization.CultureInfo("fr-fr")));
                        else
                            cmd.Parameters.AddWithValue("@cijena_sobe_od", Double.Parse(pom, CultureInfo.InvariantCulture));
                    }
                    if (flag_cijenaDo)
                    {
                        string pom = tb_cijenasobeDo.Text;
                        if (pom.ToLower().Contains(','))
                            cmd.Parameters.AddWithValue("@cijena_sobe_do", Double.Parse(pom, new System.Globalization.CultureInfo("fr-fr")));
                        else
                            cmd.Parameters.AddWithValue("@cijena_sobe_do", Double.Parse(pom, CultureInfo.InvariantCulture));
                    }
                        
                    if (flag_brojkreveta)
                        cmd.Parameters.AddWithValue("@broj_kreveta", Int32.Parse(tb_brojkreveta.Text));

                    if (flag_bracnikreveti)
                        cmd.Parameters.AddWithValue("@bracni_kreveti", Int32.Parse(tb_bracnikreveti.Text));

                    if (flag_obicnikreveti)
                        cmd.Parameters.AddWithValue("@obicni_kreveti", Int32.Parse(tb_obicnikreveti.Text));

                    //////////////////////////////////////////////////////////

                    var adaptor = new SqlDataAdapter();
                    adaptor.SelectCommand = cmd;

                    con.Open();
                    adaptor.Fill(dt);
                    DataTable Result = dt;
                    SobeDataGridView.DataSource = Result;
                }
            }

            /// ######################################################################3
/*
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
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;
            
            SqlCommand cmd2 = new SqlCommand("SELECT * FROM SOBE", connection);

            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(cmd2);
                DataTable dt2 = new DataTable();
                sda.Fill(dt2);

                // Spremi filtere.
                if (!String.IsNullOrEmpty(tb_brojsobe.Text))
                {
                    idsobe = tb_brojsobe.Text;
                    flagsoba = 1;
                }


                foreach (DataRow dr in dt2.Rows)
                {
                    ListViewItem item = new ListViewItem(dr["Id"].ToString());

                    string apartman;
                    if (dr["Apartman"].ToString() == "True") apartman = "DA";
                    else apartman = "NE";

                    string pogled;
                    if (dr["Pogled_na_more"].ToString() == "True") pogled = "DA";
                    else pogled = "NE";

                    string klima;
                    if (dr["Klima"].ToString() == "True") klima = "DA";
                    else klima = "NE";

                    string tv;
                    if (dr["TV"].ToString() == "True") tv = "DA";
                    else tv = "NE";

                    string jacuzzi;
                    if (dr["Jacuzzi"].ToString() == "True") jacuzzi = "DA";
                    else jacuzzi = "NE";

                    string sauna;
                    if (dr["Sauna"].ToString() == "True") sauna = "DA";
                    else sauna = "NE";

                    string kreveti;
                    if (dr["Broj_kreveta"].ToString() == "True") kreveti = "DA";
                    else kreveti = "NE";

                    string bracni;
                    if (dr["Bracni_kreveti"].ToString() == "True") bracni = "DA";
                    else bracni = "NE";

                    string obicni;
                    if (dr["Obicni_kreveti"].ToString() == "True") obicni = "DA";
                    else obicni = "NE";

                    item.SubItems.Add(dr["Kat"].ToString());
                    item.SubItems.Add(dr["Cijena"].ToString());
                    item.SubItems.Add(apartman);
                    item.SubItems.Add(pogled);
                    item.SubItems.Add(klima);
                    item.SubItems.Add(tv);
                    item.SubItems.Add(jacuzzi);
                    item.SubItems.Add(sauna);
                    item.SubItems.Add(kreveti);
                    item.SubItems.Add(bracni);
                    item.SubItems.Add(obicni);

                    listView1.Items.Add(item);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
*/
        }

        private void btn_rezerviraj_Click(object sender, EventArgs e)
        {
            var row = SobeDataGridView.CurrentRow;
            string ID = row.Cells[0].Value.ToString();
            DateTime datum_od = DateTime.Parse(date_od.Text);
            DateTime datum_do = DateTime.Parse(date_do.Text);
            //string datum_do = date_do.Value.ToString("dd-MMM-yy");
            Console.WriteLine("eeeeeeeeeeeeeeeeeeeeeeee" + datum_od);
            Console.WriteLine("aaaaaaaaaaaaaaaaaaaaaa" + date_od.Value.ToString("dd-MMM-yy"));

            FormOpisIRezervacijaSobaRezerviraj FormOpisIRezervacijaSobaRezerviraj1 = new FormOpisIRezervacijaSobaRezerviraj(ID,datum_od,datum_do);
            FormOpisIRezervacijaSobaRezerviraj1.Show();

            this.Close();
        }
    }
}
