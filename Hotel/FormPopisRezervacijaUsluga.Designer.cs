namespace Hotel
{
    partial class FormPopisRezervacijaUsluga
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
            this.listView_usluge = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_izmijenirez = new System.Windows.Forms.Button();
            this.btn_otkazirez = new System.Windows.Forms.Button();
            this.lbl_danrezervacije = new System.Windows.Forms.Label();
            this.date_rezervacijausluge = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.date_datum = new System.Windows.Forms.DateTimePicker();
            this.cb_neDatumi = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // listView_usluge
            // 
            this.listView_usluge.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listView_usluge.AutoArrange = false;
            this.listView_usluge.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView_usluge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_usluge.FullRowSelect = true;
            this.listView_usluge.GridLines = true;
            this.listView_usluge.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_usluge.HideSelection = false;
            this.listView_usluge.Location = new System.Drawing.Point(30, 25);
            this.listView_usluge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView_usluge.Name = "listView_usluge";
            this.listView_usluge.Size = new System.Drawing.Size(1129, 368);
            this.listView_usluge.TabIndex = 0;
            this.listView_usluge.UseCompatibleStateImageBehavior = false;
            this.listView_usluge.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID rezervacije usluge";
            this.columnHeader1.Width = 190;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ID usluge";
            this.columnHeader2.Width = 130;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Termin";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ime gosta";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Prezime gosta";
            this.columnHeader5.Width = 150;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "OIB gosta";
            this.columnHeader6.Width = 130;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Plaćeno";
            this.columnHeader7.Width = 90;
            // 
            // btn_izmijenirez
            // 
            this.btn_izmijenirez.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_izmijenirez.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_izmijenirez.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_izmijenirez.ForeColor = System.Drawing.Color.Ivory;
            this.btn_izmijenirez.Location = new System.Drawing.Point(1222, 71);
            this.btn_izmijenirez.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_izmijenirez.Name = "btn_izmijenirez";
            this.btn_izmijenirez.Size = new System.Drawing.Size(153, 97);
            this.btn_izmijenirez.TabIndex = 8;
            this.btn_izmijenirez.Text = "Izmijeni\r\nrezervaciju";
            this.btn_izmijenirez.UseVisualStyleBackColor = false;
            this.btn_izmijenirez.Click += new System.EventHandler(this.btn_izmijenirez_Click);
            // 
            // btn_otkazirez
            // 
            this.btn_otkazirez.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_otkazirez.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_otkazirez.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_otkazirez.ForeColor = System.Drawing.Color.Ivory;
            this.btn_otkazirez.Location = new System.Drawing.Point(1222, 240);
            this.btn_otkazirez.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_otkazirez.Name = "btn_otkazirez";
            this.btn_otkazirez.Size = new System.Drawing.Size(153, 93);
            this.btn_otkazirez.TabIndex = 7;
            this.btn_otkazirez.Text = "Otkaži \r\nrezervaciju";
            this.btn_otkazirez.UseVisualStyleBackColor = false;
            this.btn_otkazirez.Click += new System.EventHandler(this.btn_otkazirez_Click);
            // 
            // lbl_danrezervacije
            // 
            this.lbl_danrezervacije.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_danrezervacije.AutoSize = true;
            this.lbl_danrezervacije.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_danrezervacije.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbl_danrezervacije.Location = new System.Drawing.Point(48, 423);
            this.lbl_danrezervacije.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_danrezervacije.Name = "lbl_danrezervacije";
            this.lbl_danrezervacije.Size = new System.Drawing.Size(370, 20);
            this.lbl_danrezervacije.TabIndex = 6;
            this.lbl_danrezervacije.Text = "Prikaži sve rezervacije za određeni termin:";
            // 
            // date_rezervacijausluge
            // 
            this.date_rezervacijausluge.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.date_rezervacijausluge.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_rezervacijausluge.Location = new System.Drawing.Point(65, 482);
            this.date_rezervacijausluge.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.date_rezervacijausluge.Name = "date_rezervacijausluge";
            this.date_rezervacijausluge.Size = new System.Drawing.Size(329, 27);
            this.date_rezervacijausluge.TabIndex = 5;
            this.date_rezervacijausluge.ValueChanged += new System.EventHandler(this.date_rezervacijausluge_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(521, 423);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(368, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Prikaži sve rezervacije na određeni datum:";
            // 
            // date_datum
            // 
            this.date_datum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.date_datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_datum.Location = new System.Drawing.Point(539, 481);
            this.date_datum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.date_datum.Name = "date_datum";
            this.date_datum.Size = new System.Drawing.Size(329, 27);
            this.date_datum.TabIndex = 9;
            this.date_datum.ValueChanged += new System.EventHandler(this.date_datum_ValueChanged);
            // 
            // cb_neDatumi
            // 
            this.cb_neDatumi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cb_neDatumi.AutoSize = true;
            this.cb_neDatumi.Location = new System.Drawing.Point(939, 487);
            this.cb_neDatumi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cb_neDatumi.Name = "cb_neDatumi";
            this.cb_neDatumi.Size = new System.Drawing.Size(284, 21);
            this.cb_neDatumi.TabIndex = 11;
            this.cb_neDatumi.Text = "Ne želim filter po datumima ni terminima.";
            this.cb_neDatumi.UseVisualStyleBackColor = true;
            this.cb_neDatumi.CheckedChanged += new System.EventHandler(this.cb_neDatumi_CheckedChanged);
            // 
            // FormPopisRezervacijaUsluga
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(1423, 612);
            this.Controls.Add(this.cb_neDatumi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date_datum);
            this.Controls.Add(this.btn_izmijenirez);
            this.Controls.Add(this.btn_otkazirez);
            this.Controls.Add(this.lbl_danrezervacije);
            this.Controls.Add(this.date_rezervacijausluge);
            this.Controls.Add(this.listView_usluge);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPopisRezervacijaUsluga";
            this.Text = "Popis rezervacija usluga";
            this.Load += new System.EventHandler(this.FormPopisRezervacijaUsluga_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView_usluge;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btn_izmijenirez;
        private System.Windows.Forms.Button btn_otkazirez;
        private System.Windows.Forms.Label lbl_danrezervacije;
        private System.Windows.Forms.DateTimePicker date_rezervacijausluge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_datum;
        private System.Windows.Forms.CheckBox cb_neDatumi;
    }
}