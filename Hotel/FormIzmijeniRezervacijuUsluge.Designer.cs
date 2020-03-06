namespace Hotel
{
    partial class FormIzmijeniRezervacijuUsluge
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
            this.btn_okizmijeni = new System.Windows.Forms.Button();
            this.lbl_nemapromjeneidrez = new System.Windows.Forms.Label();
            this.tb_idrez = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_idsobe = new System.Windows.Forms.Label();
            this.tb_placeno = new System.Windows.Forms.TextBox();
            this.tb_gostoib = new System.Windows.Forms.TextBox();
            this.lbl_datumDo = new System.Windows.Forms.Label();
            this.tb_gostprezime = new System.Windows.Forms.TextBox();
            this.tb_gostime = new System.Windows.Forms.TextBox();
            this.lbl_gostime = new System.Windows.Forms.Label();
            this.lbl_gostprezime = new System.Windows.Forms.Label();
            this.tb_idsobe = new System.Windows.Forms.TextBox();
            this.lbl_gostoib = new System.Windows.Forms.Label();
            this.lbl_placeno = new System.Windows.Forms.Label();
            this.date_do = new System.Windows.Forms.DateTimePicker();
            this.lbl_izmijeniPodatke = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_okizmijeni
            // 
            this.btn_okizmijeni.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_okizmijeni.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btn_okizmijeni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_okizmijeni.Location = new System.Drawing.Point(379, 481);
            this.btn_okizmijeni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_okizmijeni.Name = "btn_okizmijeni";
            this.btn_okizmijeni.Size = new System.Drawing.Size(153, 60);
            this.btn_okizmijeni.TabIndex = 23;
            this.btn_okizmijeni.Text = "OK";
            this.btn_okizmijeni.UseVisualStyleBackColor = false;
            this.btn_okizmijeni.Click += new System.EventHandler(this.btn_okizmijeni_Click);
            // 
            // lbl_nemapromjeneidrez
            // 
            this.lbl_nemapromjeneidrez.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_nemapromjeneidrez.AutoSize = true;
            this.lbl_nemapromjeneidrez.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nemapromjeneidrez.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_nemapromjeneidrez.Location = new System.Drawing.Point(626, 50);
            this.lbl_nemapromjeneidrez.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nemapromjeneidrez.Name = "lbl_nemapromjeneidrez";
            this.lbl_nemapromjeneidrez.Size = new System.Drawing.Size(254, 18);
            this.lbl_nemapromjeneidrez.TabIndex = 22;
            this.lbl_nemapromjeneidrez.Text = "ID rezervacije se ne može promijeniti.";
            // 
            // tb_idrez
            // 
            this.tb_idrez.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_idrez.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_idrez.Location = new System.Drawing.Point(397, 40);
            this.tb_idrez.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_idrez.Name = "tb_idrez";
            this.tb_idrez.Size = new System.Drawing.Size(185, 28);
            this.tb_idrez.TabIndex = 21;
            this.tb_idrez.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 256F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_idsobe, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tb_placeno, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.tb_gostoib, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_datumDo, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tb_gostprezime, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_gostime, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_gostime, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbl_gostprezime, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tb_idsobe, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_gostoib, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lbl_placeno, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.date_do, 1, 1);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(261, 102);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(397, 346);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // lbl_idsobe
            // 
            this.lbl_idsobe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_idsobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_idsobe.Location = new System.Drawing.Point(4, 0);
            this.lbl_idsobe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_idsobe.Name = "lbl_idsobe";
            this.lbl_idsobe.Size = new System.Drawing.Size(136, 49);
            this.lbl_idsobe.TabIndex = 1;
            this.lbl_idsobe.Text = "ID usluge:";
            this.lbl_idsobe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_placeno
            // 
            this.tb_placeno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_placeno.Location = new System.Drawing.Point(183, 282);
            this.tb_placeno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_placeno.Name = "tb_placeno";
            this.tb_placeno.Size = new System.Drawing.Size(177, 27);
            this.tb_placeno.TabIndex = 14;
            this.tb_placeno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_gostoib
            // 
            this.tb_gostoib.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_gostoib.Location = new System.Drawing.Point(183, 207);
            this.tb_gostoib.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_gostoib.Name = "tb_gostoib";
            this.tb_gostoib.Size = new System.Drawing.Size(177, 27);
            this.tb_gostoib.TabIndex = 13;
            this.tb_gostoib.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_datumDo
            // 
            this.lbl_datumDo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_datumDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_datumDo.Location = new System.Drawing.Point(4, 49);
            this.lbl_datumDo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_datumDo.Name = "lbl_datumDo";
            this.lbl_datumDo.Size = new System.Drawing.Size(136, 49);
            this.lbl_datumDo.TabIndex = 3;
            this.lbl_datumDo.Text = "Datum dolaska:";
            this.lbl_datumDo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_gostprezime
            // 
            this.tb_gostprezime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_gostprezime.Location = new System.Drawing.Point(183, 158);
            this.tb_gostprezime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_gostprezime.Name = "tb_gostprezime";
            this.tb_gostprezime.Size = new System.Drawing.Size(177, 27);
            this.tb_gostprezime.TabIndex = 12;
            this.tb_gostprezime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tb_gostime
            // 
            this.tb_gostime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_gostime.Location = new System.Drawing.Point(183, 109);
            this.tb_gostime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_gostime.Name = "tb_gostime";
            this.tb_gostime.Size = new System.Drawing.Size(177, 27);
            this.tb_gostime.TabIndex = 11;
            this.tb_gostime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_gostime
            // 
            this.lbl_gostime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_gostime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gostime.Location = new System.Drawing.Point(4, 98);
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
            this.lbl_gostprezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gostprezime.Location = new System.Drawing.Point(4, 147);
            this.lbl_gostprezime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_gostprezime.Name = "lbl_gostprezime";
            this.lbl_gostprezime.Size = new System.Drawing.Size(136, 49);
            this.lbl_gostprezime.TabIndex = 5;
            this.lbl_gostprezime.Text = "Prezime gosta:";
            this.lbl_gostprezime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tb_idsobe
            // 
            this.tb_idsobe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tb_idsobe.Location = new System.Drawing.Point(183, 11);
            this.tb_idsobe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tb_idsobe.Name = "tb_idsobe";
            this.tb_idsobe.Size = new System.Drawing.Size(177, 27);
            this.tb_idsobe.TabIndex = 8;
            this.tb_idsobe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_gostoib
            // 
            this.lbl_gostoib.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_gostoib.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gostoib.Location = new System.Drawing.Point(4, 196);
            this.lbl_gostoib.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_gostoib.Name = "lbl_gostoib";
            this.lbl_gostoib.Size = new System.Drawing.Size(136, 49);
            this.lbl_gostoib.TabIndex = 6;
            this.lbl_gostoib.Text = "OIB gosta:";
            this.lbl_gostoib.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbl_placeno
            // 
            this.lbl_placeno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_placeno.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_placeno.Location = new System.Drawing.Point(4, 245);
            this.lbl_placeno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_placeno.Name = "lbl_placeno";
            this.lbl_placeno.Size = new System.Drawing.Size(136, 101);
            this.lbl_placeno.TabIndex = 7;
            this.lbl_placeno.Text = "Plaćeno (DA ili NE):";
            this.lbl_placeno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // date_do
            // 
            this.date_do.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.date_do.Location = new System.Drawing.Point(182, 60);
            this.date_do.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.date_do.Name = "date_do";
            this.date_do.Size = new System.Drawing.Size(180, 27);
            this.date_do.TabIndex = 20;
            // 
            // lbl_izmijeniPodatke
            // 
            this.lbl_izmijeniPodatke.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_izmijeniPodatke.AutoSize = true;
            this.lbl_izmijeniPodatke.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_izmijeniPodatke.Location = new System.Drawing.Point(61, 40);
            this.lbl_izmijeniPodatke.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_izmijeniPodatke.Name = "lbl_izmijeniPodatke";
            this.lbl_izmijeniPodatke.Size = new System.Drawing.Size(295, 24);
            this.lbl_izmijeniPodatke.TabIndex = 19;
            this.lbl_izmijeniPodatke.Text = "Izmijenite podatke rezervacije (ID):";
            // 
            // FormIzmijeniRezervacijuUsluge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btn_okizmijeni);
            this.Controls.Add(this.lbl_nemapromjeneidrez);
            this.Controls.Add(this.tb_idrez);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lbl_izmijeniPodatke);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormIzmijeniRezervacijuUsluge";
            this.Text = "Izmjena rezervacije usluge";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_okizmijeni;
        private System.Windows.Forms.Label lbl_nemapromjeneidrez;
        private System.Windows.Forms.TextBox tb_idrez;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lbl_idsobe;
        private System.Windows.Forms.TextBox tb_placeno;
        private System.Windows.Forms.TextBox tb_gostoib;
        private System.Windows.Forms.Label lbl_datumDo;
        private System.Windows.Forms.TextBox tb_gostprezime;
        private System.Windows.Forms.TextBox tb_gostime;
        private System.Windows.Forms.Label lbl_gostime;
        private System.Windows.Forms.Label lbl_gostprezime;
        private System.Windows.Forms.TextBox tb_idsobe;
        private System.Windows.Forms.Label lbl_gostoib;
        private System.Windows.Forms.Label lbl_placeno;
        private System.Windows.Forms.DateTimePicker date_do;
        private System.Windows.Forms.Label lbl_izmijeniPodatke;
    }
}