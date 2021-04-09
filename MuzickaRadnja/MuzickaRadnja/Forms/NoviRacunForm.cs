using MuzickaRadnja.Data.Controller;
using MuzickaRadnja.Data.DataAccess;
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
    public partial class NoviRacunForm : Form
    {
        public NoviRacunForm()
        {
            InitializeComponent();
            tbSifra.Text = RacunController.nextId();
            ucitajListuVrstaPlacanja();
            tbDatumIzdavanja.Text = DateTime.Now.ToString();
            var zaposleni = OsobaController.Read(Main.IdZaposleni);
            tbZaposleni.Text = zaposleni.Ime + " " + zaposleni.Prezime;

            ucitajListuInstrumenata();

        }

        private void ucitajListuInstrumenata()
        {
            var lista = InstrumentProdajaController.ReadAll();
            foreach (var item in lista)
                cbSifra.Items.Add(item.Id.ToString());
        }

        private void ucitajListuVrstaPlacanja()
        {
            var lista = VrstaPlacanjaController.ReadAll();
            foreach (var item in lista)
                cbVrstaPlacanja.Items.Add(item.Id.ToString()+" "+item.Naziv);
        }



        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbSifra_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Int32.Parse(cbSifra.Text);
            var instrument = InstrumentProdajaController.Read(id);
            tbNaziv.Text = instrument.Naziv;
            tbVrsta.Text = instrument.Vrsta;
            tbGodinaProizvodnje.Text = instrument.GodinaProizvodnje.Year.ToString();
            tbNabavnaCijena.Text = instrument.NabavnaCijena.ToString("0.00");
            tbProdajnaCijena.Text = instrument.MaloprodajnaCijena.ToString("0.00");
        }
    }
}
