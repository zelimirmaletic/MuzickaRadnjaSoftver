using MuzickaRadnja.Data.Controller;
using MuzickaRadnja.Data.DataAccess;
using MuzickaRadnja.Data.Model;
using System;
using System.Windows.Forms;

namespace MuzickaRadnja.Forms
{
    public partial class NovaNabavkaForm : Form
    {
        public NovaNabavkaForm()
        {
            InitializeComponent();
            ucitajListuInstrumenata();
        }

        internal void ucitajListuInstrumenata()
        {
            var lista = InstrumentController.ReadAll();
            foreach (var item in lista)
                cbSifra.Items.Add(item.Id.ToString());
        }

        private void cbPromet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPromet.Text == "prodaja")
                lblCijena.Text = "Prodajna cijena";
            else
                lblCijena.Text = "Cijena iznajmljivanja";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNovi_Click(object sender, EventArgs e)
        {
            Form form = new DodajInstrumentForm();
            form.ShowDialog();
            ucitajListuInstrumenata();
        }

        private void cbSifra_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = Int32.Parse(cbSifra.Text);
            Instrument obj = InstrumentController.Read(id);
            tbNaziv.Text = obj.Naziv;
            tbVrsta.Text = obj.Vrsta;
            tbDatumProizvodnje.Text = obj.GodinaProizvodnje.ToString();
            tbNabavnaCijena.Text = obj.NabavnaCijena.ToString("0.00");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbPromet.Text.Equals("prodaja"))
                InstrumentProdajaController.Update(new InstrumentProdaja(Int32.Parse(cbSifra.Text),tbNaziv.Text,tbVrsta.Text,DateTime.Parse(tbDatumProizvodnje.Text),Double.Parse(tbNabavnaCijena.Text),Int32.Parse(cbSifra.Text), Double.Parse(tbProdajnaCijena.Text), Int32.Parse(tbKolicina.Text), Int32.Parse(tbKolicina.Text)));
            else if (cbPromet.Text.Equals("iznajmljivanje"))
                InstrumentIznajmljivanjeController.Update(new InstrumentIznajmljivanje(Int32.Parse(cbSifra.Text), tbNaziv.Text, tbVrsta.Text, DateTime.Parse(tbDatumProizvodnje.Text), Double.Parse(tbNabavnaCijena.Text), Int32.Parse(cbSifra.Text), Double.Parse(tbProdajnaCijena.Text), Int32.Parse(tbKolicina.Text), Int32.Parse(tbKolicina.Text)));
            this.Close();
        }
    }
}
