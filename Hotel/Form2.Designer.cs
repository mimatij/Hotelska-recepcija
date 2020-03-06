namespace Hotel
{
    partial class Popis_gostiju
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
            this.Gost_ime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gost_prezime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gost_OIB = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Unos_prezime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Filtar_ime = new System.Windows.Forms.Button();
            this.Unos_ime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.Filtar_datum = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
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
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Lavender;
            this.splitContainer1.Panel2.Controls.Add(this.Unos_prezime);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.Filtar_ime);
            this.splitContainer1.Panel2.Controls.Add(this.Unos_ime);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.splitter1);
            this.splitContainer1.Panel2.Controls.Add(this.dateTimePicker1);
            this.splitContainer1.Panel2.Controls.Add(this.Filtar_datum);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Size = new System.Drawing.Size(795, 529);
            this.splitContainer1.SplitterDistance = 351;
            this.splitContainer1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Gost_ime,
            this.Gost_prezime,
            this.Gost_OIB});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(795, 351);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Gost_ime
            // 
            this.Gost_ime.Text = "Ime";
            this.Gost_ime.Width = 110;
            // 
            // Gost_prezime
            // 
            this.Gost_prezime.Text = "Prezime";
            this.Gost_prezime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Gost_prezime.Width = 110;
            // 
            // Gost_OIB
            // 
            this.Gost_OIB.Text = "OIB";
            this.Gost_OIB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Gost_OIB.Width = 110;
            // 
            // Unos_prezime
            // 
            this.Unos_prezime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Unos_prezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unos_prezime.Location = new System.Drawing.Point(192, 68);
            this.Unos_prezime.Name = "Unos_prezime";
            this.Unos_prezime.Size = new System.Drawing.Size(230, 27);
            this.Unos_prezime.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Indigo;
            this.label3.Location = new System.Drawing.Point(236, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prezime:";
            // 
            // Filtar_ime
            // 
            this.Filtar_ime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Filtar_ime.BackColor = System.Drawing.Color.Thistle;
            this.Filtar_ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filtar_ime.Location = new System.Drawing.Point(80, 109);
            this.Filtar_ime.Name = "Filtar_ime";
            this.Filtar_ime.Size = new System.Drawing.Size(202, 42);
            this.Filtar_ime.TabIndex = 2;
            this.Filtar_ime.Text = "Filtriraj po imenu";
            this.Filtar_ime.UseVisualStyleBackColor = false;
            this.Filtar_ime.Click += new System.EventHandler(this.Filtar_ime_Click);
            // 
            // Unos_ime
            // 
            this.Unos_ime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Unos_ime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Unos_ime.Location = new System.Drawing.Point(12, 68);
            this.Unos_ime.Name = "Unos_ime";
            this.Unos_ime.Size = new System.Drawing.Size(159, 27);
            this.Unos_ime.TabIndex = 4;
            this.Unos_ime.TextChanged += new System.EventHandler(this.Unos_ime_prezime_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(37, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime:";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(443, 174);
            this.splitter1.TabIndex = 8;
            this.splitter1.TabStop = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(470, 66);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(275, 27);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // Filtar_datum
            // 
            this.Filtar_datum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Filtar_datum.BackColor = System.Drawing.Color.Thistle;
            this.Filtar_datum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filtar_datum.Location = new System.Drawing.Point(505, 109);
            this.Filtar_datum.Name = "Filtar_datum";
            this.Filtar_datum.Size = new System.Drawing.Size(201, 42);
            this.Filtar_datum.TabIndex = 3;
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
            this.label2.Location = new System.Drawing.Point(557, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datum:";
            // 
            // Popis_gostiju
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 529);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Popis_gostiju";
            this.Text = "Popis gostiju";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox Unos_ime;
        private System.Windows.Forms.Button Filtar_datum;
        private System.Windows.Forms.Button Filtar_ime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Gost_ime;
        private System.Windows.Forms.ColumnHeader Gost_prezime;
        private System.Windows.Forms.ColumnHeader Gost_OIB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Unos_prezime;
        private System.Windows.Forms.Splitter splitter1;
    }
}