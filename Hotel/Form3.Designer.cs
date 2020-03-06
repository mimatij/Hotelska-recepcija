namespace Hotel
{
    partial class Popis_osoblja
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OIB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Datum_rod = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Mob = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Zanimanje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ukloni_zaposlenika = new System.Windows.Forms.Button();
            this.Izmijeni = new System.Windows.Forms.Button();
            this.Dodaj_novi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.splitContainer1.Panel2.Controls.Add(this.Ukloni_zaposlenika);
            this.splitContainer1.Panel2.Controls.Add(this.Izmijeni);
            this.splitContainer1.Panel2.Controls.Add(this.Dodaj_novi);
            this.splitContainer1.Size = new System.Drawing.Size(1172, 450);
            this.splitContainer1.SplitterDistance = 360;
            this.splitContainer1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ime,
            this.Prezime,
            this.OIB,
            this.Datum_rod,
            this.Mob,
            this.Email,
            this.Zanimanje});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1172, 360);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // Ime
            // 
            this.Ime.Text = "Ime";
            this.Ime.Width = 90;
            // 
            // Prezime
            // 
            this.Prezime.Text = "Prezime";
            this.Prezime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Prezime.Width = 110;
            // 
            // OIB
            // 
            this.OIB.Text = "OIB";
            this.OIB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.OIB.Width = 110;
            // 
            // Datum_rod
            // 
            this.Datum_rod.Text = "Datum rođenja";
            this.Datum_rod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Datum_rod.Width = 110;
            // 
            // Mob
            // 
            this.Mob.Text = "Mobitel";
            this.Mob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Mob.Width = 110;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Email.Width = 110;
            // 
            // Zanimanje
            // 
            this.Zanimanje.Text = "Zanimanje";
            this.Zanimanje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Zanimanje.Width = 110;
            // 
            // Ukloni_zaposlenika
            // 
            this.Ukloni_zaposlenika.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Ukloni_zaposlenika.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ukloni_zaposlenika.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Ukloni_zaposlenika.Location = new System.Drawing.Point(427, 15);
            this.Ukloni_zaposlenika.Name = "Ukloni_zaposlenika";
            this.Ukloni_zaposlenika.Size = new System.Drawing.Size(223, 59);
            this.Ukloni_zaposlenika.TabIndex = 2;
            this.Ukloni_zaposlenika.Text = "Ukloni zaposlenika";
            this.Ukloni_zaposlenika.UseVisualStyleBackColor = false;
            this.Ukloni_zaposlenika.Click += new System.EventHandler(this.Ukloni_zaposlenika_Click);
            // 
            // Izmijeni
            // 
            this.Izmijeni.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Izmijeni.Enabled = false;
            this.Izmijeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Izmijeni.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Izmijeni.Location = new System.Drawing.Point(795, 15);
            this.Izmijeni.Name = "Izmijeni";
            this.Izmijeni.Size = new System.Drawing.Size(214, 59);
            this.Izmijeni.TabIndex = 1;
            this.Izmijeni.Text = "Izmijeni";
            this.Izmijeni.UseVisualStyleBackColor = false;
            this.Izmijeni.Click += new System.EventHandler(this.Izmijeni_Click);
            // 
            // Dodaj_novi
            // 
            this.Dodaj_novi.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Dodaj_novi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dodaj_novi.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Dodaj_novi.Location = new System.Drawing.Point(74, 15);
            this.Dodaj_novi.Name = "Dodaj_novi";
            this.Dodaj_novi.Size = new System.Drawing.Size(223, 59);
            this.Dodaj_novi.TabIndex = 0;
            this.Dodaj_novi.Text = "Dodaj novog zaposlenika";
            this.Dodaj_novi.UseVisualStyleBackColor = false;
            this.Dodaj_novi.Click += new System.EventHandler(this.Dodaj_novi_Click);
            // 
            // Popis_osoblja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Popis_osoblja";
            this.Text = "Popis osoblja";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.ColumnHeader OIB;
        private System.Windows.Forms.ColumnHeader Datum_rod;
        private System.Windows.Forms.ColumnHeader Mob;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Zanimanje;
        private System.Windows.Forms.Button Izmijeni;
        private System.Windows.Forms.Button Dodaj_novi;
        private System.Windows.Forms.Button Ukloni_zaposlenika;
    }
}