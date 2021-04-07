
namespace MuzickaRadnja.Forms
{
    partial class NovaUplataForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovaUplataForm));
            this.NaslovPanel = new System.Windows.Forms.Panel();
            this.lblNaslov = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSifraUgovora = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbZaposleni = new System.Windows.Forms.TextBox();
            this.tbVrstaPlacanja = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NaslovPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NaslovPanel
            // 
            this.NaslovPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.NaslovPanel.Controls.Add(this.lblNaslov);
            this.NaslovPanel.Controls.Add(this.pictureBox1);
            this.NaslovPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NaslovPanel.Location = new System.Drawing.Point(0, 0);
            this.NaslovPanel.Name = "NaslovPanel";
            this.NaslovPanel.Size = new System.Drawing.Size(313, 50);
            this.NaslovPanel.TabIndex = 7;
            // 
            // lblNaslov
            // 
            this.lblNaslov.AutoSize = true;
            this.lblNaslov.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNaslov.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(0)))), ((int)(((byte)(217)))));
            this.lblNaslov.Location = new System.Drawing.Point(56, 0);
            this.lblNaslov.Name = "lblNaslov";
            this.lblNaslov.Size = new System.Drawing.Size(176, 45);
            this.lblNaslov.TabIndex = 4;
            this.lblNaslov.Text = "Uplata rate";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.label3.Location = new System.Drawing.Point(5, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 21);
            this.label3.TabIndex = 31;
            this.label3.Text = "Vrsta plaćanja";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(5, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 21);
            this.label1.TabIndex = 33;
            this.label1.Text = "Šifra ugovora";
            // 
            // cbSifraUgovora
            // 
            this.cbSifraUgovora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSifraUgovora.FormattingEnabled = true;
            this.cbSifraUgovora.Location = new System.Drawing.Point(133, 63);
            this.cbSifraUgovora.Name = "cbSifraUgovora";
            this.cbSifraUgovora.Size = new System.Drawing.Size(168, 23);
            this.cbSifraUgovora.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.label2.Location = new System.Drawing.Point(5, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 21);
            this.label2.TabIndex = 35;
            this.label2.Text = "Zaposleni";
            // 
            // tbZaposleni
            // 
            this.tbZaposleni.Location = new System.Drawing.Point(133, 141);
            this.tbZaposleni.Name = "tbZaposleni";
            this.tbZaposleni.ReadOnly = true;
            this.tbZaposleni.Size = new System.Drawing.Size(168, 23);
            this.tbZaposleni.TabIndex = 36;
            // 
            // tbVrstaPlacanja
            // 
            this.tbVrstaPlacanja.Location = new System.Drawing.Point(133, 102);
            this.tbVrstaPlacanja.Name = "tbVrstaPlacanja";
            this.tbVrstaPlacanja.ReadOnly = true;
            this.tbVrstaPlacanja.Size = new System.Drawing.Size(168, 23);
            this.tbVrstaPlacanja.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(24)))), ((int)(((byte)(51)))));
            this.label4.Location = new System.Drawing.Point(5, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 21);
            this.label4.TabIndex = 38;
            this.label4.Text = "Svrha";
            // 
            // NovaUplataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbVrstaPlacanja);
            this.Controls.Add(this.tbZaposleni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbSifraUgovora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NaslovPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NovaUplataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uplata rate";
            this.NaslovPanel.ResumeLayout(false);
            this.NaslovPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel NaslovPanel;
        private System.Windows.Forms.Label lblNaslov;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSifraUgovora;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbZaposleni;
        private System.Windows.Forms.TextBox tbVrstaPlacanja;
        private System.Windows.Forms.Label label4;
    }
}