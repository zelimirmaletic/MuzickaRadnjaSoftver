using MuzickaRadnja.Data.Controller;
using MuzickaRadnja.Data.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuzickaRadnja.Forms
{
    public partial class NovaUplataForm : Form
    {
        public NovaUplataForm()
        {
            InitializeComponent();
            ucitajListuUgovora();
            ucitajListuVrstaPlacanja();
            var zaposleni = OsobaController.Read(Main.IdZaposleni);
            tbZaposleni.Text = zaposleni.Ime + " " + zaposleni.Prezime;
            tbDatumUplate.Text = DateTime.Now.ToString();
        }

        private void ucitajListuUgovora()
        {
            var lista = UgovorController.ReadAll();
            foreach (var item in lista)
                if(item.BrojRata!=0)
                    cbSifraUgovora.Items.Add(item.Id.ToString());
        }

        private void ucitajListuVrstaPlacanja()
        {
            var lista = VrstaPlacanjaController.ReadAll();
            foreach (var item in lista)
                cbVrstaPlacanja.Items.Add(item.Id.ToString() + " " + item.Naziv);
        }



        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbSifraUgovora_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbIznosRate.Text = UgovorController.GetIznosRate(Int32.Parse(cbSifraUgovora.Text)).ToString("0.00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbSifraUgovora.Text.Equals(""))
                MessageBox.Show("Унесите шифру уговора!","Грешка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            if (cbVrstaPlacanja.Text.Equals(""))
                MessageBox.Show("Унесите шифру плаћања!", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                UgovorUplataController.Insert(new UgovorUplata(0, Int32.Parse(cbSifraUgovora.Text), Int32.Parse((cbVrstaPlacanja.Text.Split(' '))[0]),Main.IdZaposleni,tbSvrha.Text,DateTime.Now,tbKomentar.Text));
            this.Close();
        }
    }
}
