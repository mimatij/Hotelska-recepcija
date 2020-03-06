namespace Hotel
{
    partial class Racun_sobe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Id_rezervacije = new System.Windows.Forms.Label();
            this.TraziPoRezervacijamaNocenja = new System.Windows.Forms.Button();
            this.Izdaj_racun = new System.Windows.Forms.Button();
            this.Racun1 = new System.Windows.Forms.ListView();
            this.Korisnik = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Datum_od = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Datum_do = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cijena_noc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Soba = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Racun2 = new System.Windows.Forms.ListView();
            this.Korisnik_usluge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Usluga = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Cijena_usluge = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ukupna_cijena = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Ispis = new System.Windows.Forms.Button();
            this.Usluga_nocenja = new System.Windows.Forms.RadioButton();
            this.Ostale_usluge = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.TraziPoRezervacijamaUsluga = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(292, 228);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(302, 34);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Id_rezervacije
            // 
            this.Id_rezervacije.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Id_rezervacije.AutoSize = true;
            this.Id_rezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Id_rezervacije.ForeColor = System.Drawing.Color.Red;
            this.Id_rezervacije.Location = new System.Drawing.Point(371, 165);
            this.Id_rezervacije.MaximumSize = new System.Drawing.Size(200, 200);
            this.Id_rezervacije.Name = "Id_rezervacije";
            this.Id_rezervacije.Size = new System.Drawing.Size(168, 25);
            this.Id_rezervacije.TabIndex = 1;
            this.Id_rezervacije.Text = "Broj rezervacije:";
            this.Id_rezervacije.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TraziPoRezervacijamaNocenja
            // 
            this.TraziPoRezervacijamaNocenja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TraziPoRezervacijamaNocenja.BackColor = System.Drawing.Color.Snow;
            this.TraziPoRezervacijamaNocenja.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TraziPoRezervacijamaNocenja.Location = new System.Drawing.Point(645, 232);
            this.TraziPoRezervacijamaNocenja.Name = "TraziPoRezervacijamaNocenja";
            this.TraziPoRezervacijamaNocenja.Size = new System.Drawing.Size(111, 33);
            this.TraziPoRezervacijamaNocenja.TabIndex = 2;
            this.TraziPoRezervacijamaNocenja.Text = "Search";
            this.TraziPoRezervacijamaNocenja.UseVisualStyleBackColor = false;
            this.TraziPoRezervacijamaNocenja.Visible = false;
            this.TraziPoRezervacijamaNocenja.Click += new System.EventHandler(this.TraziPoRezervacijamaNocenja_Click);
            // 
            // Izdaj_racun
            // 
            this.Izdaj_racun.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Izdaj_racun.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Izdaj_racun.Enabled = false;
            this.Izdaj_racun.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Izdaj_racun.Location = new System.Drawing.Point(349, 288);
            this.Izdaj_racun.Name = "Izdaj_racun";
            this.Izdaj_racun.Size = new System.Drawing.Size(190, 66);
            this.Izdaj_racun.TabIndex = 3;
            this.Izdaj_racun.Text = "IZDAJ RAČUN";
            this.Izdaj_racun.UseVisualStyleBackColor = false;
            this.Izdaj_racun.Click += new System.EventHandler(this.Izdaj_racun_Click);
            // 
            // Racun1
            // 
            this.Racun1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Racun1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Racun1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Korisnik,
            this.Datum_od,
            this.Datum_do,
            this.Cijena_noc,
            this.Soba});
            this.Racun1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Racun1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Racun1.HideSelection = false;
            this.Racun1.Location = new System.Drawing.Point(23, 22);
            this.Racun1.Name = "Racun1";
            this.Racun1.Size = new System.Drawing.Size(841, 280);
            this.Racun1.TabIndex = 4;
            this.Racun1.UseCompatibleStateImageBehavior = false;
            this.Racun1.View = System.Windows.Forms.View.Details;
            this.Racun1.Visible = false;
            // 
            // Korisnik
            // 
            this.Korisnik.Text = "Korisnik";
            this.Korisnik.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Korisnik.Width = 110;
            // 
            // Datum_od
            // 
            this.Datum_od.Text = "Datum_od";
            this.Datum_od.Width = 110;
            // 
            // Datum_do
            // 
            this.Datum_do.Text = "Datum_do";
            this.Datum_do.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Datum_do.Width = 110;
            // 
            // Cijena_noc
            // 
            this.Cijena_noc.Text = "Cijena/noć";
            this.Cijena_noc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cijena_noc.Width = 110;
            // 
            // Soba
            // 
            this.Soba.Text = "Soba";
            this.Soba.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Soba.Width = 110;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.Racun2);
            this.panel1.Controls.Add(this.Racun1);
            this.panel1.Controls.Add(this.Ukupna_cijena);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(50, 414);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(891, 405);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // Racun2
            // 
            this.Racun2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Racun2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Racun2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Korisnik_usluge,
            this.Usluga,
            this.Cijena_usluge});
            this.Racun2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Racun2.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.Racun2.HideSelection = false;
            this.Racun2.Location = new System.Drawing.Point(23, 22);
            this.Racun2.Name = "Racun2";
            this.Racun2.Size = new System.Drawing.Size(790, 280);
            this.Racun2.TabIndex = 5;
            this.Racun2.UseCompatibleStateImageBehavior = false;
            this.Racun2.View = System.Windows.Forms.View.Details;
            this.Racun2.Visible = false;
            // 
            // Korisnik_usluge
            // 
            this.Korisnik_usluge.Text = "Korisnik";
            this.Korisnik_usluge.Width = 150;
            // 
            // Usluga
            // 
            this.Usluga.Text = "Usluga";
            this.Usluga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Usluga.Width = 150;
            // 
            // Cijena_usluge
            // 
            this.Cijena_usluge.Text = "Cijena";
            this.Cijena_usluge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Cijena_usluge.Width = 150;
            // 
            // Ukupna_cijena
            // 
            this.Ukupna_cijena.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ukupna_cijena.AutoSize = true;
            this.Ukupna_cijena.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ukupna_cijena.ForeColor = System.Drawing.Color.DarkRed;
            this.Ukupna_cijena.Location = new System.Drawing.Point(712, 344);
            this.Ukupna_cijena.Name = "Ukupna_cijena";
            this.Ukupna_cijena.Size = new System.Drawing.Size(101, 25);
            this.Ukupna_cijena.TabIndex = 1;
            this.Ukupna_cijena.Text = "00000 kn";
            this.Ukupna_cijena.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(605, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Za platiti:";
            this.label1.Visible = false;
            // 
            // Ispis
            // 
            this.Ispis.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Ispis.BackColor = System.Drawing.Color.SeaShell;
            this.Ispis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ispis.Location = new System.Drawing.Point(800, 860);
            this.Ispis.Name = "Ispis";
            this.Ispis.Size = new System.Drawing.Size(141, 53);
            this.Ispis.TabIndex = 6;
            this.Ispis.Text = "Ispiši";
            this.Ispis.UseVisualStyleBackColor = false;
            this.Ispis.Visible = false;
            this.Ispis.Click += new System.EventHandler(this.Ispis_Click);
            // 
            // Usluga_nocenja
            // 
            this.Usluga_nocenja.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Usluga_nocenja.AutoSize = true;
            this.Usluga_nocenja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Usluga_nocenja.Location = new System.Drawing.Point(380, 62);
            this.Usluga_nocenja.Name = "Usluga_nocenja";
            this.Usluga_nocenja.Size = new System.Drawing.Size(159, 24);
            this.Usluga_nocenja.TabIndex = 7;
            this.Usluga_nocenja.TabStop = true;
            this.Usluga_nocenja.Text = "Usluga noćenja";
            this.Usluga_nocenja.UseVisualStyleBackColor = true;
            this.Usluga_nocenja.CheckedChanged += new System.EventHandler(this.Usluga_nocenja_CheckedChanged);
            // 
            // Ostale_usluge
            // 
            this.Ostale_usluge.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Ostale_usluge.AutoSize = true;
            this.Ostale_usluge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ostale_usluge.Location = new System.Drawing.Point(380, 101);
            this.Ostale_usluge.Name = "Ostale_usluge";
            this.Ostale_usluge.Size = new System.Drawing.Size(146, 24);
            this.Ostale_usluge.TabIndex = 8;
            this.Ostale_usluge.TabStop = true;
            this.Ostale_usluge.Text = "Ostale usluge";
            this.Ostale_usluge.UseVisualStyleBackColor = true;
            this.Ostale_usluge.CheckedChanged += new System.EventHandler(this.Ostale_usluge_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(382, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Vrsta usluge:";
            // 
            // TraziPoRezervacijamaUsluga
            // 
            this.TraziPoRezervacijamaUsluga.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TraziPoRezervacijamaUsluga.BackColor = System.Drawing.Color.Snow;
            this.TraziPoRezervacijamaUsluga.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TraziPoRezervacijamaUsluga.Location = new System.Drawing.Point(645, 232);
            this.TraziPoRezervacijamaUsluga.Name = "TraziPoRezervacijamaUsluga";
            this.TraziPoRezervacijamaUsluga.Size = new System.Drawing.Size(111, 33);
            this.TraziPoRezervacijamaUsluga.TabIndex = 10;
            this.TraziPoRezervacijamaUsluga.Text = "Search";
            this.TraziPoRezervacijamaUsluga.UseVisualStyleBackColor = false;
            this.TraziPoRezervacijamaUsluga.Visible = false;
            this.TraziPoRezervacijamaUsluga.Click += new System.EventHandler(this.TraziPoRezervacijamaUsluga_Click);
            // 
            // Racun_sobe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1029, 1021);
            this.Controls.Add(this.TraziPoRezervacijamaUsluga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ostale_usluge);
            this.Controls.Add(this.Usluga_nocenja);
            this.Controls.Add(this.Ispis);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Izdaj_racun);
            this.Controls.Add(this.TraziPoRezervacijamaNocenja);
            this.Controls.Add(this.Id_rezervacije);
            this.Controls.Add(this.textBox1);
            this.Name = "Racun_sobe";
            this.Text = "Račun";
            this.Load += new System.EventHandler(this.Racun_sobe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Id_rezervacije;
        private System.Windows.Forms.Button TraziPoRezervacijamaNocenja;
        private System.Windows.Forms.Button Izdaj_racun;
        private System.Windows.Forms.ListView Racun1;
        private System.Windows.Forms.ColumnHeader Datum_od;
        private System.Windows.Forms.ColumnHeader Datum_do;
        private System.Windows.Forms.ColumnHeader Cijena_noc;
        private System.Windows.Forms.ColumnHeader Soba;
        private System.Windows.Forms.ColumnHeader Korisnik;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Ukupna_cijena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Ispis;
        private System.Windows.Forms.RadioButton Usluga_nocenja;
        private System.Windows.Forms.RadioButton Ostale_usluge;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView Racun2;
        private System.Windows.Forms.ColumnHeader Korisnik_usluge;
        private System.Windows.Forms.ColumnHeader Usluga;
        private System.Windows.Forms.ColumnHeader Cijena_usluge;
        private System.Windows.Forms.Button TraziPoRezervacijamaUsluga;
    }
}

