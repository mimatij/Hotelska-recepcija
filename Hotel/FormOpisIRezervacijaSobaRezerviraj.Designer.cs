namespace Hotel
{
    partial class FormOpisIRezervacijaSobaRezerviraj
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
            this.lb_gostime = new System.Windows.Forms.Label();
            this.lb_gostprezime = new System.Windows.Forms.Label();
            this.lb_gostoib = new System.Windows.Forms.Label();
            this.tb_gostime = new System.Windows.Forms.TextBox();
            this.tb_gostprezime = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.tb_gostoib = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // lb_gostime
            // 
            this.lb_gostime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_gostime.AutoSize = true;
            this.lb_gostime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gostime.ForeColor = System.Drawing.Color.White;
            this.lb_gostime.Location = new System.Drawing.Point(228, 74);
            this.lb_gostime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_gostime.Name = "lb_gostime";
            this.lb_gostime.Size = new System.Drawing.Size(124, 29);
            this.lb_gostime.TabIndex = 0;
            this.lb_gostime.Text = "Ime gosta:";
            // 
            // lb_gostprezime
            // 
            this.lb_gostprezime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_gostprezime.AutoSize = true;
            this.lb_gostprezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gostprezime.ForeColor = System.Drawing.Color.White;
            this.lb_gostprezime.Location = new System.Drawing.Point(213, 157);
            this.lb_gostprezime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_gostprezime.Name = "lb_gostprezime";
            this.lb_gostprezime.Size = new System.Drawing.Size(173, 29);
            this.lb_gostprezime.TabIndex = 1;
            this.lb_gostprezime.Text = "Prezime gosta:";
            // 
            // lb_gostoib
            // 
            this.lb_gostoib.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lb_gostoib.AutoSize = true;
            this.lb_gostoib.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_gostoib.ForeColor = System.Drawing.Color.White;
            this.lb_gostoib.Location = new System.Drawing.Point(226, 252);
            this.lb_gostoib.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_gostoib.Name = "lb_gostoib";
            this.lb_gostoib.Size = new System.Drawing.Size(125, 29);
            this.lb_gostoib.TabIndex = 2;
            this.lb_gostoib.Text = "OIB gosta:";
            // 
            // tb_gostime
            // 
            this.tb_gostime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_gostime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_gostime.Location = new System.Drawing.Point(437, 74);
            this.tb_gostime.Margin = new System.Windows.Forms.Padding(4);
            this.tb_gostime.Name = "tb_gostime";
            this.tb_gostime.Size = new System.Drawing.Size(178, 30);
            this.tb_gostime.TabIndex = 3;
            // 
            // tb_gostprezime
            // 
            this.tb_gostprezime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_gostprezime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_gostprezime.Location = new System.Drawing.Point(437, 157);
            this.tb_gostprezime.Margin = new System.Windows.Forms.Padding(4);
            this.tb_gostprezime.Name = "tb_gostprezime";
            this.tb_gostprezime.Size = new System.Drawing.Size(178, 30);
            this.tb_gostprezime.TabIndex = 4;
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_ok.BackColor = System.Drawing.Color.LightCyan;
            this.btn_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok.Location = new System.Drawing.Point(316, 373);
            this.btn_ok.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(151, 78);
            this.btn_ok.TabIndex = 6;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = false;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // tb_gostoib
            // 
            this.tb_gostoib.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.tb_gostoib.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_gostoib.Location = new System.Drawing.Point(437, 252);
            this.tb_gostoib.Mask = "00000000000";
            this.tb_gostoib.Name = "tb_gostoib";
            this.tb_gostoib.Size = new System.Drawing.Size(178, 30);
            this.tb_gostoib.TabIndex = 7;
            // 
            // FormOpisIRezervacijaSobaRezerviraj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(849, 548);
            this.Controls.Add(this.tb_gostoib);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.tb_gostprezime);
            this.Controls.Add(this.tb_gostime);
            this.Controls.Add(this.lb_gostoib);
            this.Controls.Add(this.lb_gostprezime);
            this.Controls.Add(this.lb_gostime);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormOpisIRezervacijaSobaRezerviraj";
            this.Text = "Rezervacija sobe";
            this.Load += new System.EventHandler(this.FormOpisIRezervacijaSobaRezerviraj_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_gostime;
        private System.Windows.Forms.Label lb_gostprezime;
        private System.Windows.Forms.Label lb_gostoib;
        private System.Windows.Forms.TextBox tb_gostime;
        private System.Windows.Forms.TextBox tb_gostprezime;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.MaskedTextBox tb_gostoib;
    }
}