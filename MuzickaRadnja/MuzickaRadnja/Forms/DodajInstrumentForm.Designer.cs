
namespace MuzickaRadnja.Forms
{
    partial class DodajInstrumentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajInstrumentForm));
            this.lblNaslov = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NaslovPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbSifra = new System.Windows.Forms.TextBox();
            this.tbNaziv = new System.Windows.Forms.TextBox();
            this.tbVrsta = new System.Windows.Forms.TextBox();
            this.tbGodProizvodnje = new System.Windows.Forms.TextBox();
            this.tbNabavnaCijena = new System.Windows.Forms.TextBox();
            this.cbPromet = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCijena = new System.Windows.Forms.Label();
            this.tbProdajnaCijena = new System.Windows.Forms.TextBox();
            this.tbKolicina = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.NaslovPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNaslov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(0)))), ((int)(((byte)(217)))));
            this.lblNaslov.Location = new System.Drawing.Point(56, 0);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(249, 45);
            this.lblNaslov.TabIndex = 4;
            this.lblNaslov.Text = "Novi instrument";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // NaslovPanel
            // 
            this.NaslovPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.NaslovPanel.Controls.Add(this.lblNaslov);
            this.NaslovPanel.Controls.Add(this.pictureBox1);
            this.NaslovPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NaslovPanel.Location = new System.Drawing.Point(0, 0);
            this.NaslovPanel.Name = "NaslovPanel";
            this.NaslovPanel.Size = new System.Drawing.Size(434, 50);
            this.NaslovPanel.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(8, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 7;
            this.label1.Text = "Šifra";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(8, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Naziv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(8, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Vrsta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(12, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Godina proizvodnje";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.label5.Location = new System.Drawing.Point(12, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nabavna cijena";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.label6.Location = new System.Drawing.Point(12, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 21);
            this.label6.TabIndex = 12;
            this.label6.Text = "Promet";
            // 
            // tbSifra
            // 
            this.tbSifra.Location = new System.Drawing.Point(63, 74);
            this.tbSifra.Name = "tbSifra";
            this.tbSifra.ReadOnly = true;
            this.tbSifra.Size = new System.Drawing.Size(72, 23);
            this.tbSifra.TabIndex = 13;
            // 
            // tbNaziv
            // 
            this.tbNaziv.Location = new System.Drawing.Point(63, 109);
            this.tbNaziv.Name = "tbNaziv";
            this.tbNaziv.Size = new System.Drawing.Size(359, 23);
            this.tbNaziv.TabIndex = 14;
            // 
            // tbVrsta
            // 
            this.tbVrsta.Location = new System.Drawing.Point(63, 149);
            this.tbVrsta.Name = "tbVrsta";
            this.tbVrsta.Size = new System.Drawing.Size(359, 23);
            this.tbVrsta.TabIndex = 15;
            // 
            // tbGodProizvodnje
            // 
            this.tbGodProizvodnje.Location = new System.Drawing.Point(164, 184);
            this.tbGodProizvodnje.Name = "tbGodProizvodnje";
            this.tbGodProizvodnje.Size = new System.Drawing.Size(258, 23);
            this.tbGodProizvodnje.TabIndex = 16;
            // 
            // tbNabavnaCijena
            // 
            this.tbNabavnaCijena.Location = new System.Drawing.Point(164, 223);
            this.tbNabavnaCijena.Name = "tbNabavnaCijena";
            this.tbNabavnaCijena.Size = new System.Drawing.Size(258, 23);
            this.tbNabavnaCijena.TabIndex = 17;
            // 
            // cbPromet
            // 
            this.cbPromet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPromet.FormattingEnabled = true;
            this.cbPromet.Items.AddRange(new object[] {
            "prodaja",
            "iznajmljivanje"});
            this.cbPromet.Location = new System.Drawing.Point(164, 265);
            this.cbPromet.Name = "cbPromet";
            this.cbPromet.Size = new System.Drawing.Size(141, 23);
            this.cbPromet.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.label7.Location = new System.Drawing.Point(12, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 21);
            this.label7.TabIndex = 19;
            this.label7.Text = "Količina";
            // 
            // lblCijena
            // 
            this.lblCijena.AutoSize = true;
            this.lblCijena.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCijena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.lblCijena.Location = new System.Drawing.Point(12, 312);
            this.lblCijena.Name = "lblCijena";
            this.lblCijena.Size = new System.Drawing.Size(116, 21);
            this.lblCijena.TabIndex = 20;
            this.lblCijena.Text = "Prodajna cijena";
            // 
            // tbProdajnaCijena
            // 
            this.tbProdajnaCijena.Location = new System.Drawing.Point(164, 312);
            this.tbProdajnaCijena.Name = "tbProdajnaCijena";
            this.tbProdajnaCijena.Size = new System.Drawing.Size(258, 23);
            this.tbProdajnaCijena.TabIndex = 21;
            // 
            // tbKolicina
            // 
            this.tbKolicina.Location = new System.Drawing.Point(164, 354);
            this.tbKolicina.Name = "tbKolicina";
            this.tbKolicina.Size = new System.Drawing.Size(258, 23);
            this.tbKolicina.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(189)))), ((int)(((byte)(198)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(342, 392);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 30);
            this.button1.TabIndex = 23;
            this.button1.Text = "Sačuvaj";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(0)))), ((int)(((byte)(217)))));
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(256, 392);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 30);
            this.button2.TabIndex = 24;
            this.button2.Text = "Otkaži";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // DodajInstrumentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 432);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbKolicina);
            this.Controls.Add(this.tbProdajnaCijena);
            this.Controls.Add(this.lblCijena);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbPromet);
            this.Controls.Add(this.tbNabavnaCijena);
            this.Controls.Add(this.tbGodProizvodnje);
            this.Controls.Add(this.tbVrsta);
            this.Controls.Add(this.tbNaziv);
            this.Controls.Add(this.tbSifra);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NaslovPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DodajInstrumentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promet";
            this.Load += new System.EventHandler(this.DodajInstrumentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.NaslovPanel.ResumeLayout(false);
            this.NaslovPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel NaslovPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbSifra;
        private System.Windows.Forms.TextBox tbNaziv;
        private System.Windows.Forms.TextBox tbVrsta;
        private System.Windows.Forms.TextBox tbGodProizvodnje;
        private System.Windows.Forms.TextBox tbNabavnaCijena;
        private System.Windows.Forms.ComboBox cbPromet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCijena;
        private System.Windows.Forms.TextBox tbProdajnaCijena;
        private System.Windows.Forms.TextBox tbKolicina;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}