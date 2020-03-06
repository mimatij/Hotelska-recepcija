namespace Hotel
{
    partial class FormPopisRezervacijaSobaPocetno
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.date_danrezervacije = new System.Windows.Forms.DateTimePicker();
            this.lbl_danrezervacije = new System.Windows.Forms.Label();
            this.btn_otkazirez = new System.Windows.Forms.Button();
            this.btn_izmijenirez = new System.Windows.Forms.Button();
            this.cb_neDatum = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(17, 16);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1084, 387);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID rezervacije";
            this.columnHeader1.Width = 105;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID sobe";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Datum dolaska";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Datum odlaska";
            this.columnHeader4.Width = 125;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ime gosta";
            this.columnHeader5.Width = 85;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Prezime gosta";
            this.columnHeader6.Width = 110;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "OIB gosta";
            this.columnHeader7.Width = 90;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Plaćeno";
            this.columnHeader8.Width = 85;
            // 
            // date_danrezervacije
            // 
            this.date_danrezervacije.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_danrezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_danrezervacije.Location = new System.Drawing.Point(30, 462);
            this.date_danrezervacije.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.date_danrezervacije.Name = "date_danrezervacije";
            this.date_danrezervacije.Size = new System.Drawing.Size(265, 27);
            this.date_danrezervacije.TabIndex = 1;
            this.date_danrezervacije.ValueChanged += new System.EventHandler(this.date_danrezervacije_ValueChanged);
            // 
            // lbl_danrezervacije
            // 
            this.lbl_danrezervacije.AutoSize = true;
            this.lbl_danrezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_danrezervacije.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_danrezervacije.Location = new System.Drawing.Point(13, 427);
            this.lbl_danrezervacije.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_danrezervacije.Name = "lbl_danrezervacije";
            this.lbl_danrezervacije.Size = new System.Drawing.Size(347, 20);
            this.lbl_danrezervacije.TabIndex = 2;
            this.lbl_danrezervacije.Text = "Prikaži sve rezervacije na određeni dan:";
            // 
            // btn_otkazirez
            // 
            this.btn_otkazirez.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_otkazirez.BackColor = System.Drawing.Color.SeaShell;
            this.btn_otkazirez.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_otkazirez.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_otkazirez.Location = new System.Drawing.Point(653, 430);
            this.btn_otkazirez.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_otkazirez.Name = "btn_otkazirez";
            this.btn_otkazirez.Size = new System.Drawing.Size(191, 76);
            this.btn_otkazirez.TabIndex = 3;
            this.btn_otkazirez.Text = "Otkaži rezervaciju";
            this.btn_otkazirez.UseVisualStyleBackColor = false;
            this.btn_otkazirez.Click += new System.EventHandler(this.btn_otkazirez_Click);
            // 
            // btn_izmijenirez
            // 
            this.btn_izmijenirez.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_izmijenirez.BackColor = System.Drawing.Color.SeaShell;
            this.btn_izmijenirez.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_izmijenirez.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_izmijenirez.Location = new System.Drawing.Point(892, 430);
            this.btn_izmijenirez.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_izmijenirez.Name = "btn_izmijenirez";
            this.btn_izmijenirez.Size = new System.Drawing.Size(157, 76);
            this.btn_izmijenirez.TabIndex = 4;
            this.btn_izmijenirez.Text = "Izmijeni rezervaciju";
            this.btn_izmijenirez.UseVisualStyleBackColor = false;
            this.btn_izmijenirez.Click += new System.EventHandler(this.btn_izmijenirez_Click);
            // 
            // cb_neDatum
            // 
            this.cb_neDatum.AutoSize = true;
            this.cb_neDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_neDatum.Location = new System.Drawing.Point(347, 462);
            this.cb_neDatum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_neDatum.Name = "cb_neDatum";
            this.cb_neDatum.Size = new System.Drawing.Size(222, 24);
            this.cb_neDatum.TabIndex = 5;
            this.cb_neDatum.Text = "Ne želim filter po datumu.";
            this.cb_neDatum.UseVisualStyleBackColor = true;
            this.cb_neDatum.CheckedChanged += new System.EventHandler(this.cb_neDatum_CheckedChanged);
            // 
            // FormPopisRezervacijaSobaPocetno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSalmon;
            this.ClientSize = new System.Drawing.Size(1155, 537);
            this.Controls.Add(this.cb_neDatum);
            this.Controls.Add(this.btn_izmijenirez);
            this.Controls.Add(this.btn_otkazirez);
            this.Controls.Add(this.lbl_danrezervacije);
            this.Controls.Add(this.date_danrezervacije);
            this.Controls.Add(this.listView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPopisRezervacijaSobaPocetno";
            this.Text = "Popis rezervacija soba";
            this.Load += new System.EventHandler(this.FormPopisRezervacijaSobaPocetno_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.DateTimePicker date_danrezervacije;
        private System.Windows.Forms.Label lbl_danrezervacije;
        private System.Windows.Forms.Button btn_otkazirez;
        private System.Windows.Forms.Button btn_izmijenirez;
        private System.Windows.Forms.CheckBox cb_neDatum;
    }
}