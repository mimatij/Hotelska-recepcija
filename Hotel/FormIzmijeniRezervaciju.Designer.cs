namespace Hotel
{
    partial class FormIzmijeniRezervaciju
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
            this.lbl_izmijeniPodatke = new System.Windows.Forms.Label();
            this.lbl_idsobe = new System.Windows.Forms.Label();
            this.lbl_datumOd = new System.Windows.Forms.Label();
            this.lbl_datumDo = new System.Windows.Forms.Label();
            this.lbl_gostime = new System.Windows.Forms.Label();
            this.lbl_gostprezime = new System.Windows.Forms.Label();
            this.lbl_gostoib = new System.Windows.Forms.Label();
            this.lbl_placeno = new System.Windows.Forms.Label();
            this.tb_idsobe = new System.Windows.Forms.TextBox();
            this.tb_gostprezime = new System.Windows.Forms.TextBox();
            this.tb_gostoib = new System.Windows.Forms.TextBox();
            this.tb_placeno = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tb_gostime = new System.Windows.Forms.TextBox();
            this.date_od = new System.Windows.Forms.DateTimePicker();
            this.date_do = new System.Windows.Forms.DateTimePicker();
            this.tb_idrez = new System.Windows.Forms.TextBox();
            this.lbl_nemapromjeneidrez = new System.Windows.Forms.Label();
            this.btn_okizmijeni = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_izmijeniPodatke
            // 
            this.lbl_izmijeniPodatke.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_izmijeniPodatke.AutoSize = true;
            this.lbl_izmijeniPodatke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_izmijeniPodatke.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_izmijeniPodatke.Location = new System.Drawing.Point(23, 46);
            this.lbl_izmijeniPodatke.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_izmijeniPodatke.Name = "lbl_izmijeniPodatke";
            this.lbl_izmijeniPodatke.Size = new System.Drawing.Size(347, 25);
            this.lbl_izmijeniPodatke.TabIndex = 0;
            this.lbl_izmijeniPodatke.Text = "Izmijenite podatke rezervacije (ID):";
            // 
            // lbl_idsobe
            // 
            this.lbl_idsobe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_idsobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idsobe.Location = new System.Drawing.Point(6, 0);
            this.lbl_idsobe.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_idsobe.Name = "lbl_idsobe";
            this.lbl_idsobe.Size = new System.Drawing.Size(138, 77);
            this.lbl_idsobe.TabIndex = 1;
            this.lbl_idsobe.Text = "ID sobe:";
            this.lbl_idsobe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_datumOd
            // 
            this.lbl_datumOd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_datumOd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datumOd.Location = new System.Drawing.Point(6, 77);
            this.lbl_datumOd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_datumOd.Name = "lbl_datumOd";
            this.lbl_datumOd.Size = new System.Drawing.Size(138, 77);
            this.lbl_datumOd.TabIndex = 2;
            this.lbl_datumOd.Text = "Datum dolaska:";
            this.lbl_datumOd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_datumDo
            // 
            this.lbl_datumDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_datumDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datumDo.Location = new System.Drawing.Point(6, 154);
            this.lbl_datumDo.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_datumDo.Name = "lbl_datumDo";
            this.lbl_datumDo.Size = new System.Drawing.Size(138, 77);
            this.lbl_datumDo.TabIndex = 3;
            this.lbl_datumDo.Text = "Datum odlaska:";
            this.lbl_datumDo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_gostime
            // 
            this.lbl_gostime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_gostime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gostime.Location = new System.Drawing.Point(6, 231);
            this.lbl_gostime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_gostime.Name = "lbl_gostime";
            this.lbl_gostime.Size = new System.Drawing.Size(138, 77);
            this.lbl_gostime.TabIndex = 4;
            this.lbl_gostime.Text = "Ime gosta:";
            this.lbl_gostime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_gostprezime
            // 
            this.lbl_gostprezime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_gostprezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gostprezime.Location = new System.Drawing.Point(6, 308);
            this.lbl_gostprezime.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_gostprezime.Name = "lbl_gostprezime";
            this.lbl_gostprezime.Size = new System.Drawing.Size(138, 77);
            this.lbl_gostprezime.TabIndex = 5;
            this.lbl_gostprezime.Text = "Prezime gosta:";
            this.lbl_gostprezime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_gostoib
            // 
            this.lbl_gostoib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_gostoib.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gostoib.Location = new System.Drawing.Point(6, 385);
            this.lbl_gostoib.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_gostoib.Name = "lbl_gostoib";
            this.lbl_gostoib.Size = new System.Drawing.Size(138, 77);
            this.lbl_gostoib.TabIndex = 6;
            this.lbl_gostoib.Text = "OIB gosta:";
            this.lbl_gostoib.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_placeno
            // 
            this.lbl_placeno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_placeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_placeno.Location = new System.Drawing.Point(6, 462);
            this.lbl_placeno.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_placeno.Name = "lbl_placeno";
            this.lbl_placeno.Size = new System.Drawing.Size(138, 77);
            this.lbl_placeno.TabIndex = 7;
            this.lbl_placeno.Text = "Plaćeno (DA ili NE):";
            this.lbl_placeno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_idsobe
            // 
            this.tb_idsobe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_idsobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_idsobe.Location = new System.Drawing.Point(216, 24);
            this.tb_idsobe.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_idsobe.Name = "tb_idsobe";
            this.tb_idsobe.Size = new System.Drawing.Size(271, 28);
            this.tb_idsobe.TabIndex = 8;
            this.tb_idsobe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_gostprezime
            // 
            this.tb_gostprezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_gostprezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_gostprezime.Location = new System.Drawing.Point(219, 332);
            this.tb_gostprezime.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_gostprezime.Name = "tb_gostprezime";
            this.tb_gostprezime.Size = new System.Drawing.Size(264, 28);
            this.tb_gostprezime.TabIndex = 12;
            this.tb_gostprezime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_gostoib
            // 
            this.tb_gostoib.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_gostoib.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_gostoib.Location = new System.Drawing.Point(219, 409);
            this.tb_gostoib.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_gostoib.Name = "tb_gostoib";
            this.tb_gostoib.Size = new System.Drawing.Size(264, 28);
            this.tb_gostoib.TabIndex = 13;
            this.tb_gostoib.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_placeno
            // 
            this.tb_placeno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_placeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_placeno.Location = new System.Drawing.Point(219, 486);
            this.tb_placeno.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_placeno.Name = "tb_placeno";
            this.tb_placeno.Size = new System.Drawing.Size(264, 28);
            this.tb_placeno.TabIndex = 14;
            this.tb_placeno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 330F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_idsobe, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_placeno, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lbl_datumOd, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_gostoib, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_datumDo, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tb_gostprezime, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.tb_gostime, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_gostime, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbl_gostprezime, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.tb_idsobe, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_gostoib, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lbl_placeno, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.date_od, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.date_do, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(87, 113);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(553, 533);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // tb_gostime
            // 
            this.tb_gostime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_gostime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_gostime.Location = new System.Drawing.Point(219, 255);
            this.tb_gostime.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_gostime.Name = "tb_gostime";
            this.tb_gostime.Size = new System.Drawing.Size(264, 28);
            this.tb_gostime.TabIndex = 11;
            this.tb_gostime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // date_od
            // 
            this.date_od.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date_od.CustomFormat = "dd.MM.yy";
            this.date_od.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_od.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_od.Location = new System.Drawing.Point(220, 101);
            this.date_od.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.date_od.Name = "date_od";
            this.date_od.Size = new System.Drawing.Size(263, 28);
            this.date_od.TabIndex = 19;
            // 
            // date_do
            // 
            this.date_do.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date_do.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_do.Location = new System.Drawing.Point(218, 178);
            this.date_do.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.date_do.Name = "date_do";
            this.date_do.Size = new System.Drawing.Size(267, 28);
            this.date_do.TabIndex = 20;
            // 
            // tb_idrez
            // 
            this.tb_idrez.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_idrez.Location = new System.Drawing.Point(382, 44);
            this.tb_idrez.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.tb_idrez.Name = "tb_idrez";
            this.tb_idrez.Size = new System.Drawing.Size(237, 30);
            this.tb_idrez.TabIndex = 16;
            this.tb_idrez.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_nemapromjeneidrez
            // 
            this.lbl_nemapromjeneidrez.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_nemapromjeneidrez.AutoSize = true;
            this.lbl_nemapromjeneidrez.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nemapromjeneidrez.ForeColor = System.Drawing.Color.Red;
            this.lbl_nemapromjeneidrez.Location = new System.Drawing.Point(656, 51);
            this.lbl_nemapromjeneidrez.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_nemapromjeneidrez.Name = "lbl_nemapromjeneidrez";
            this.lbl_nemapromjeneidrez.Size = new System.Drawing.Size(291, 20);
            this.lbl_nemapromjeneidrez.TabIndex = 17;
            this.lbl_nemapromjeneidrez.Text = "ID rezervacije se ne može promijeniti.";
            // 
            // btn_okizmijeni
            // 
            this.btn_okizmijeni.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_okizmijeni.BackColor = System.Drawing.Color.FloralWhite;
            this.btn_okizmijeni.Location = new System.Drawing.Point(243, 678);
            this.btn_okizmijeni.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btn_okizmijeni.Name = "btn_okizmijeni";
            this.btn_okizmijeni.Size = new System.Drawing.Size(169, 76);
            this.btn_okizmijeni.TabIndex = 18;
            this.btn_okizmijeni.Text = "OK";
            this.btn_okizmijeni.UseVisualStyleBackColor = false;
            this.btn_okizmijeni.Click += new System.EventHandler(this.btn_okizmijeni_Click);
            // 
            // FormIzmijeniRezervaciju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.ClientSize = new System.Drawing.Size(983, 773);
            this.Controls.Add(this.btn_okizmijeni);
            this.Controls.Add(this.lbl_nemapromjeneidrez);
            this.Controls.Add(this.tb_idrez);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lbl_izmijeniPodatke);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormIzmijeniRezervaciju";
            this.Text = "Izmijeni rezervaciju";
            this.Load += new System.EventHandler(this.FormIzmijeniRezervaciju_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_izmijeniPodatke;
        private System.Windows.Forms.Label lbl_idsobe;
        private System.Windows.Forms.Label lbl_datumOd;
        private System.Windows.Forms.Label lbl_datumDo;
        private System.Windows.Forms.Label lbl_gostime;
        private System.Windows.Forms.Label lbl_gostprezime;
        private System.Windows.Forms.Label lbl_gostoib;
        private System.Windows.Forms.Label lbl_placeno;
        private System.Windows.Forms.TextBox tb_idsobe;
        private System.Windows.Forms.TextBox tb_gostprezime;
        private System.Windows.Forms.TextBox tb_gostoib;
        private System.Windows.Forms.TextBox tb_placeno;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox tb_idrez;
        private System.Windows.Forms.Label lbl_nemapromjeneidrez;
        private System.Windows.Forms.Button btn_okizmijeni;
        private System.Windows.Forms.DateTimePicker date_od;
        private System.Windows.Forms.DateTimePicker date_do;
        private System.Windows.Forms.TextBox tb_gostime;
    }
}