namespace Hotel
{
    partial class Raspored
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
            this.Radi_od = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Radi_do = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Datum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Zaduzenje = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Filtar_datum = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Unos_prezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Filtar_ime = new System.Windows.Forms.Button();
            this.Unos_ime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Ukloni_zaduzenje = new System.Windows.Forms.Button();
            this.Dodaj_zaduzenje = new System.Windows.Forms.Button();
            this.ident = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(1, -2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.LavenderBlush;
            this.splitContainer1.Panel2.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel2.Controls.Add(this.Filtar_datum);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.Unos_prezime);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.Filtar_ime);
            this.splitContainer1.Panel2.Controls.Add(this.Unos_ime);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(1456, 428);
            this.splitContainer1.SplitterDistance = 1006;
            this.splitContainer1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ime,
            this.Prezime,
            this.OIB,
            this.Radi_od,
            this.Radi_do,
            this.Datum,
            this.Zaduzenje,
            this.ident});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1006, 428);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
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
            // Radi_od
            // 
            this.Radi_od.Text = "Radi od";
            this.Radi_od.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Radi_od.Width = 110;
            // 
            // Radi_do
            // 
            this.Radi_do.Text = "Radi do";
            this.Radi_do.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Radi_do.Width = 110;
            // 
            // Datum
            // 
            this.Datum.Text = "Datum";
            this.Datum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Datum.Width = 110;
            // 
            // Zaduzenje
            // 
            this.Zaduzenje.Text = "Zaduženje";
            this.Zaduzenje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Zaduzenje.Width = 110;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(86, 279);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(275, 27);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // Filtar_datum
            // 
            this.Filtar_datum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Filtar_datum.BackColor = System.Drawing.Color.Thistle;
            this.Filtar_datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filtar_datum.Location = new System.Drawing.Point(121, 322);
            this.Filtar_datum.Name = "Filtar_datum";
            this.Filtar_datum.Size = new System.Drawing.Size(201, 42);
            this.Filtar_datum.TabIndex = 14;
            this.Filtar_datum.Text = "Filtriraj po datumu";
            this.Filtar_datum.UseVisualStyleBackColor = false;
            this.Filtar_datum.Click += new System.EventHandler(this.Filtar_datum_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(173, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Datum:";
            // 
            // Unos_prezime
            // 
            this.Unos_prezime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Unos_prezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unos_prezime.Location = new System.Drawing.Point(207, 84);
            this.Unos_prezime.Name = "Unos_prezime";
            this.Unos_prezime.Size = new System.Drawing.Size(230, 27);
            this.Unos_prezime.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(279, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Prezime:";
            // 
            // Filtar_ime
            // 
            this.Filtar_ime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Filtar_ime.BackColor = System.Drawing.Color.Thistle;
            this.Filtar_ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filtar_ime.Location = new System.Drawing.Point(105, 130);
            this.Filtar_ime.Name = "Filtar_ime";
            this.Filtar_ime.Size = new System.Drawing.Size(202, 42);
            this.Filtar_ime.TabIndex = 9;
            this.Filtar_ime.Text = "Filtriraj po imenu";
            this.Filtar_ime.UseVisualStyleBackColor = false;
            this.Filtar_ime.Click += new System.EventHandler(this.Filtar_ime_Click);
            // 
            // Unos_ime
            // 
            this.Unos_ime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Unos_ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unos_ime.Location = new System.Drawing.Point(33, 84);
            this.Unos_ime.Name = "Unos_ime";
            this.Unos_ime.Size = new System.Drawing.Size(159, 27);
            this.Unos_ime.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(92, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ime:";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Snow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Ukloni_zaduzenje);
            this.panel1.Controls.Add(this.Dodaj_zaduzenje);
            this.panel1.Location = new System.Drawing.Point(1, 427);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1456, 119);
            this.panel1.TabIndex = 1;
            // 
            // Ukloni_zaduzenje
            // 
            this.Ukloni_zaduzenje.BackColor = System.Drawing.Color.Thistle;
            this.Ukloni_zaduzenje.Enabled = false;
            this.Ukloni_zaduzenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ukloni_zaduzenje.Location = new System.Drawing.Point(364, 26);
            this.Ukloni_zaduzenje.Name = "Ukloni_zaduzenje";
            this.Ukloni_zaduzenje.Size = new System.Drawing.Size(169, 73);
            this.Ukloni_zaduzenje.TabIndex = 1;
            this.Ukloni_zaduzenje.Text = "Ukloni zaduženje";
            this.Ukloni_zaduzenje.UseVisualStyleBackColor = false;
            this.Ukloni_zaduzenje.Click += new System.EventHandler(this.Ukloni_zaduzenje_Click);
            // 
            // Dodaj_zaduzenje
            // 
            this.Dodaj_zaduzenje.BackColor = System.Drawing.Color.Thistle;
            this.Dodaj_zaduzenje.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dodaj_zaduzenje.Location = new System.Drawing.Point(37, 26);
            this.Dodaj_zaduzenje.Name = "Dodaj_zaduzenje";
            this.Dodaj_zaduzenje.Size = new System.Drawing.Size(172, 73);
            this.Dodaj_zaduzenje.TabIndex = 0;
            this.Dodaj_zaduzenje.Text = "Dodaj zaduženje";
            this.Dodaj_zaduzenje.UseVisualStyleBackColor = false;
            this.Dodaj_zaduzenje.Click += new System.EventHandler(this.Dodaj_zaduzenje_Click);
            // 
            // ident
            // 
            this.ident.Text = "Id";
            this.ident.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ident.Width = 110;
            // 
            // Raspored
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 547);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Raspored";
            this.Text = "Raspored";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox Unos_prezime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Filtar_ime;
        private System.Windows.Forms.TextBox Unos_ime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button Filtar_datum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Ime;
        private System.Windows.Forms.ColumnHeader Prezime;
        private System.Windows.Forms.ColumnHeader OIB;
        private System.Windows.Forms.ColumnHeader Radi_od;
        private System.Windows.Forms.ColumnHeader Radi_do;
        private System.Windows.Forms.ColumnHeader Datum;
        private System.Windows.Forms.ColumnHeader Zaduzenje;
        private System.Windows.Forms.Button Ukloni_zaduzenje;
        private System.Windows.Forms.Button Dodaj_zaduzenje;
        private System.Windows.Forms.ColumnHeader ident;
    }
}