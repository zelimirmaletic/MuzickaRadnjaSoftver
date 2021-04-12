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
    public partial class NoviUgovorForm : Form
    {
        public NoviUgovorForm()
        {
            InitializeComponent();
            tbSifra.Text = UgovorController.nextId();
            ucitajListuVrstaPlacanja();
            tbDatumIzdavanja.Text = DateTime.Now.ToString();
            var zaposleni = OsobaController.Read(Main.IdZaposleni);
            tbZaposleni.Text = zaposleni.Ime + " " + zaposleni.Prezime;
            ucitajListuInstrumenata();
            ucitajListuKlijenata();
        }

        private void ucitajListuVrstaPlacanja()
        {
            var lista = VrstaPlacanjaController.ReadAll();
            foreach (var item in lista)
                cbVrstaPlacanja.Items.Add(item.Id.ToString() + " " + item.Naziv);
        }

        private void ucitajListuInstrumenata()
        {
            var lista = InstrumentIznajmljivanjeController.ReadAll();
            foreach (var item in lista)
                cbSifra.Items.Add(item.Id.ToString());
        }
        private void ucitajListuKlijenata()
        {
            var lista = KlijentController.ReadAll();
            foreach (var item in lista)
                cbKlijent.Items.Add(item.Id.ToString()+" "+item.Ime+" "+item.Prezime);
        }

        private void cbSifra_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Int32.Parse(cbSifra.Text);
            var obj = InstrumentIznajmljivanjeController.Read(id);
            tbNaziv.Text = obj.Naziv;
            tbVrsta.Text = obj.Vrsta;
            tbGodinaProizvodnje.Text = obj.GodinaProizvodnje.Year.ToString();
            tbNabavnaCijena.Text = obj.NabavnaCijena.ToString("0.00");
            tbCijena.Text = obj.CijenaIznajmljivanja.ToString("0.00");
            tbKolicinaDostupna.Text = obj.DostupnaKolicina.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ocistiUnos();
        }

        private void ocistiUnos()
        {
            tbNaziv.Text = "";
            tbVrsta.Text = "";
            tbGodinaProizvodnje.Text = "";
            tbNabavnaCijena.Text = "";
            tbCijena.Text = "";
            tbKolicinaDostupna.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (cbVrstaPlacanja.Text.Equals(""))
                MessageBox.Show("Унесите шифру плаћања из падајућег менија.", "Грешка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else if (cbKlijent.Text.Equals(""))
                MessageBox.Show("Одаберите клијента из падајућег менија.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (cbKlijent.Text.Equals(""))
                MessageBox.Show("Унесите период изнајмљивања.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (dgvTabela.Rows.Count==1)
                MessageBox.Show("Додајте инструмент за изнамљивање у табелу инструмената.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //SACUVAJ PODATKE U BAZU
            //Sacuvaj podatke o racunu
            int idUgovor = Int32.Parse(tbSifra.Text);
            string vrstaPlacanja = (cbVrstaPlacanja.Text.Split(' '))[0];
            int klijent = Int32.Parse((cbKlijent.Text.Split(' '))[0]);
            int periodIznajmljivanja = Int32.Parse(tbPeriodIznajmljivanja.Text);
            bool naRate = cbNaRate.Checked;
            
            //Sacuvaj ugovor
            var ugovor = new Ugovor(idUgovor,klijent,Main.IdZaposleni,DateTime.Now,naRate,periodIznajmljivanja,false,true,tbOpis.Text,periodIznajmljivanja,0);
            
            UgovorController.Insert(ugovor);

            //Sacuvaj podatke o artiklima na ugovoru
            for (int i = 0; i < dgvTabela.Rows.Count - 1; i++)
            {
                int IdInstrument = Int32.Parse(dgvTabela.Rows[i].Cells[0].Value.ToString());
                var stavka = new UgovorImaInstrumentIznajmljivanje(0,idUgovor, IdInstrument, 1);
                UgovorImaInstrumentIznajmljivanjeController.Insert(stavka);
            }

            this.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbNaziv.Text.Equals(""))
                MessageBox.Show("Унесите шифру артикла из падајућег менија.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DataGridViewRow drvr = (DataGridViewRow)dgvTabela.Rows[0].Clone();
                drvr.Cells[0].Value = cbSifra.Text;
                drvr.Cells[1].Value = tbNaziv.Text;
                drvr.Cells[2].Value = tbVrsta.Text;
                drvr.Cells[3].Value = tbGodinaProizvodnje.Text;
                drvr.Cells[4].Value = Double.Parse(tbNabavnaCijena.Text).ToString("0.00");
                drvr.Cells[5].Value = Double.Parse(tbCijena.Text).ToString("0.00");
                drvr.Cells[6].Value = Double.Parse(tbKolicinaDostupna.Text);
                dgvTabela.Rows.Add(drvr);
                ocistiUnos();
            }
        }
    }
}
