using MuzickaRadnja.Data.Controller;
using MuzickaRadnja.Data.DataAccess;
using MuzickaRadnja.Data.Model;
using System;
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
            tbKolicinaDostupna.Text = instrument.DostupnaKolicina.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ocistiUnos();
        }

        private void ocistiUnos()
        {
            tbNaziv.Text = "";
            tbVrsta.Text = "";
            tbProdajnaCijena.Text = "";
            tbKolicinaDostupna.Text = "";
            tbKolicinaProdaja.Text = "";
            tbGodinaProizvodnje.Text = "";
            tbNabavnaCijena.Text = "";
            cbSifra.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Double.Parse(tbPopust.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unijeti popust nije validan!");
                return;
            }
            if (tbNaziv.Text.Equals("")||tbKolicinaProdaja.Text.Equals(""))
            {
                MessageBox.Show("Odaberite prodajni artikal i unesite prodajnu kolicinu!");
                return;
            }
            else if(Int32.Parse(tbKolicinaProdaja.Text) > Int32.Parse(tbKolicinaDostupna.Text))
            {
                MessageBox.Show("Unijeta prodajna količina je veća od količine na skladištu. Molimo Vas da unesete novu količinu!");
                tbKolicinaProdaja.Text = ("");
                return;
            }
            else
            {
                DataGridViewRow drvr = (DataGridViewRow)dgvTabela.Rows[0].Clone();
                drvr.Cells[0].Value = cbSifra.Text;
                drvr.Cells[1].Value = tbNaziv.Text;
                drvr.Cells[2].Value = tbVrsta.Text;
                drvr.Cells[3].Value = tbGodinaProizvodnje.Text;
                double cijena = double.Parse(tbProdajnaCijena.Text);
                double cijenaSaPopustom = cijena - cijena * (Double.Parse(tbPopust.Text)/100);
                drvr.Cells[4].Value = cijena.ToString("0.00");
                drvr.Cells[5].Value = cijenaSaPopustom.ToString("0.00");
                drvr.Cells[6].Value = ((cijenaSaPopustom*Main.PDV)+cijenaSaPopustom).ToString("0.00");
                drvr.Cells[7].Value = tbKolicinaProdaja.Text;
                double kolicina = Double.Parse(tbKolicinaProdaja.Text);
                drvr.Cells[8].Value = (((cijenaSaPopustom * Main.PDV) + cijenaSaPopustom) * kolicina).ToString("0.00");
                dgvTabela.Rows.Add(drvr);
                //Azuriraj labelu ukupno
                azurirajUkupanIznos((((cijenaSaPopustom * Main.PDV) + cijenaSaPopustom) * kolicina));
                ocistiUnos();
            }
        }

        private void azurirajUkupanIznos(double iznos)
        {
            tbUkupno.Text = (Double.Parse(tbUkupno.Text) + iznos).ToString("0.00");
        }

        private void btnIzbrisiRed_Click(object sender, EventArgs e)
        {
            if(dgvTabela.SelectedRows.Count==0)
                MessageBox.Show("Red za brisanje nije selektovan, molimo Vas da selektujete red.");
            else
            {
                double iznos = Double.Parse(dgvTabela.SelectedRows[0].Cells[7].Value.ToString());
                azurirajUkupanIznos(-iznos);
                dgvTabela.Rows.Remove(dgvTabela.SelectedRows[0]);
            }
        }

        private void btnSacuvaj_Click(object sender, EventArgs e)
        {
            if(cbVrstaPlacanja.Text.Equals(""))
            {
                MessageBox.Show("Vrsta placanja nije odabrana, molimo Vas da odaberete vrstu placanja.");
                return;
            }
            //Sacuvaj podatke o racunu
            int idRacun = Int32.Parse(tbSifra.Text);
            string vrstaPlacanja = (cbVrstaPlacanja.Text.Split(' '))[0];
            var racun = new Racun(idRacun,Main.IdZaposleni,Int32.Parse(vrstaPlacanja),DateTime.Now,Double.Parse(tbPopust.Text)/100,Double.Parse(tbUkupno.Text));
            RacunController.Insert(racun);
            //Sacuvaj podatke o artiklima na racunu
            for(int i=0;i<dgvTabela.Rows.Count-1;i++)
            {
                int idArtikal = Int32.Parse(dgvTabela.Rows[i].Cells[0].Value.ToString());
                int kolicina = Int32.Parse(dgvTabela.Rows[i].Cells[7].Value.ToString());
                var stavka = new Racun_ima_InstrumentProdaja(idRacun, idArtikal, kolicina);
                RacunImaInstrumentProdajaController.Insert(stavka);
            }

            this.Close();
        }
    }
}
