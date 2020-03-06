namespace Hotel
{
    partial class FormRezervirajUslugu
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
            this.btn_okRezervirajUslugu = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_gostoibusluga = new System.Windows.Forms.TextBox();
            this.lbl_datum = new System.Windows.Forms.Label();
            this.tb_gostprezimeusluga = new System.Windows.Forms.TextBox();
            this.tb_gostimeusluga = new System.Windows.Forms.TextBox();
            this.lbl_gostime = new System.Windows.Forms.Label();
            this.lbl_gostprezime = new System.Windows.Forms.Label();
            this.date_usluga = new System.Windows.Forms.DateTimePicker();
            this.lbl_gostoib = new System.Windows.Forms.Label();
            this.lbl_izmijeniPodatke = new System.Windows.Forms.Label();
            this.cb_tipusluge = new System.Windows.Forms.ComboBox();
            this.cb_usluga = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_okRezervirajUslugu
            // 
            this.btn_okRezervirajUslugu.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_okRezervirajUslugu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_okRezervirajUslugu.Location = new System.Drawing.Point(250, 427);
            this.btn_okRezervirajUslugu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_okRezervirajUslugu.Name = "btn_okRezervirajUslugu";
            this.btn_okRezervirajUslugu.Size = new System.Drawing.Size(208, 80);
            this.btn_okRezervirajUslugu.TabIndex = 23;
            this.btn_okRezervirajUslugu.Text = "OK, rezerviraj!";
            this.btn_okRezervirajUslugu.UseVisualStyleBackColor = false;
            this.btn_okRezervirajUslugu.Click += new System.EventHandler(this.btn_okRezervirajUslugu_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.tableLayoutPanel1.Controls.Add(this.tb_gostoibusluga, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_datum, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_gostprezimeusluga, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_gostimeusluga, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_gostime, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_gostprezime, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.date_usluga, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_gostoib, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(154, 162);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(397, 198);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // tb_gostoibusluga
            // 
            this.tb_gostoibusluga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_gostoibusluga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_gostoibusluga.Location = new System.Drawing.Point(183, 159);
            this.tb_gostoibusluga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_gostoibusluga.Name = "tb_gostoibusluga";
            this.tb_gostoibusluga.Size = new System.Drawing.Size(177, 27);
            this.tb_gostoibusluga.TabIndex = 13;
            this.tb_gostoibusluga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_datum
            // 
            this.lbl_datum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datum.ForeColor = System.Drawing.Color.MintCream;
            this.lbl_datum.Location = new System.Drawing.Point(4, 0);
            this.lbl_datum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_datum.Name = "lbl_datum";
            this.lbl_datum.Size = new System.Drawing.Size(136, 49);
            this.lbl_datum.TabIndex = 3;
            this.lbl_datum.Text = "Datum dolaska:";
            this.lbl_datum.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_gostprezimeusluga
            // 
            this.tb_gostprezimeusluga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_gostprezimeusluga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_gostprezimeusluga.Location = new System.Drawing.Point(183, 109);
            this.tb_gostprezimeusluga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_gostprezimeusluga.Name = "tb_gostprezimeusluga";
            this.tb_gostprezimeusluga.Size = new System.Drawing.Size(177, 27);
            this.tb_gostprezimeusluga.TabIndex = 12;
            this.tb_gostprezimeusluga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_gostimeusluga
            // 
            this.tb_gostimeusluga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_gostimeusluga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_gostimeusluga.Location = new System.Drawing.Point(183, 60);
            this.tb_gostimeusluga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_gostimeusluga.Name = "tb_gostimeusluga";
            this.tb_gostimeusluga.Size = new System.Drawing.Size(177, 27);
            this.tb_gostimeusluga.TabIndex = 11;
            this.tb_gostimeusluga.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_gostime
            // 
            this.lbl_gostime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_gostime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gostime.ForeColor = System.Drawing.Color.MintCream;
            this.lbl_gostime.Location = new System.Drawing.Point(4, 49);
            this.lbl_gostime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_gostime.Name = "lbl_gostime";
            this.lbl_gostime.Size = new System.Drawing.Size(136, 49);
            this.lbl_gostime.TabIndex = 4;
            this.lbl_gostime.Text = "Ime gosta:";
            this.lbl_gostime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_gostprezime
            // 
            this.lbl_gostprezime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_gostprezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gostprezime.ForeColor = System.Drawing.Color.MintCream;
            this.lbl_gostprezime.Location = new System.Drawing.Point(4, 98);
            this.lbl_gostprezime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_gostprezime.Name = "lbl_gostprezime";
            this.lbl_gostprezime.Size = new System.Drawing.Size(136, 49);
            this.lbl_gostprezime.TabIndex = 5;
            this.lbl_gostprezime.Text = "Prezime gosta:";
            this.lbl_gostprezime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // date_usluga
            // 
            this.date_usluga.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date_usluga.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            this.date_usluga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_usluga.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_usluga.Location = new System.Drawing.Point(166, 11);
            this.date_usluga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.date_usluga.Name = "date_usluga";
            this.date_usluga.Size = new System.Drawing.Size(212, 27);
            this.date_usluga.TabIndex = 15;
            // 
            // lbl_gostoib
            // 
            this.lbl_gostoib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_gostoib.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gostoib.ForeColor = System.Drawing.Color.MintCream;
            this.lbl_gostoib.Location = new System.Drawing.Point(4, 147);
            this.lbl_gostoib.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_gostoib.Name = "lbl_gostoib";
            this.lbl_gostoib.Size = new System.Drawing.Size(136, 51);
            this.lbl_gostoib.TabIndex = 6;
            this.lbl_gostoib.Text = "OIB gosta:";
            this.lbl_gostoib.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_izmijeniPodatke
            // 
            this.lbl_izmijeniPodatke.AutoSize = true;
            this.lbl_izmijeniPodatke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_izmijeniPodatke.ForeColor = System.Drawing.Color.MintCream;
            this.lbl_izmijeniPodatke.Location = new System.Drawing.Point(25, 61);
            this.lbl_izmijeniPodatke.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_izmijeniPodatke.Name = "lbl_izmijeniPodatke";
            this.lbl_izmijeniPodatke.Size = new System.Drawing.Size(171, 24);
            this.lbl_izmijeniPodatke.TabIndex = 19;
            this.lbl_izmijeniPodatke.Text = "Izaberite tip usluge:";
            // 
            // cb_tipusluge
            // 
            this.cb_tipusluge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_tipusluge.FormattingEnabled = true;
            this.cb_tipusluge.Items.AddRange(new object[] {
            "Masaža",
            "Bazen",
            "Teretana",
            "Restoran"});
            this.cb_tipusluge.Location = new System.Drawing.Point(204, 61);
            this.cb_tipusluge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_tipusluge.Name = "cb_tipusluge";
            this.cb_tipusluge.Size = new System.Drawing.Size(160, 28);
            this.cb_tipusluge.TabIndex = 25;
            this.cb_tipusluge.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cb_usluga
            // 
            this.cb_usluga.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_usluga.FormattingEnabled = true;
            this.cb_usluga.Location = new System.Drawing.Point(547, 61);
            this.cb_usluga.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_usluga.Name = "cb_usluga";
            this.cb_usluga.Size = new System.Drawing.Size(160, 28);
            this.cb_usluga.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MintCream;
            this.label1.Location = new System.Drawing.Point(386, 64);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Izaberite uslugu:";
            // 
            // FormRezervirajUslugu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(812, 554);
            this.Controls.Add(this.cb_usluga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_tipusluge);
            this.Controls.Add(this.btn_okRezervirajUslugu);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lbl_izmijeniPodatke);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormRezervirajUslugu";
            this.Text = "Rezerviraj uslugu";
            this.Load += new System.EventHandler(this.FormRezervirajUslugu_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_okRezervirajUslugu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_gostoibusluga;
        private System.Windows.Forms.Label lbl_datum;
        private System.Windows.Forms.TextBox tb_gostprezimeusluga;
        private System.Windows.Forms.TextBox tb_gostimeusluga;
        private System.Windows.Forms.Label lbl_gostime;
        private System.Windows.Forms.Label lbl_gostprezime;
        private System.Windows.Forms.Label lbl_gostoib;
        private System.Windows.Forms.Label lbl_izmijeniPodatke;
        private System.Windows.Forms.ComboBox cb_tipusluge;
        private System.Windows.Forms.ComboBox cb_usluga;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_usluga;
    }
}