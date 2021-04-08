using MuzickaRadnja.Data.Controller;
using MuzickaRadnja.Data.DataAccess;
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
    public partial class DodajInstrumentForm : Form
    {
        public DodajInstrumentForm()
        {
            InitializeComponent();
            tbSifra.Text = InstrumentController.nextId();
        }

        private void DodajInstrumentForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(tbSifra.Text);
            string naziv = tbNaziv.Text;
            string vrsta = cbVrsta.Text;
            DateTime godinaProizvodnje = dateTimePicker1.Value;
            double nabavnaCijena = Double.Parse(tbNabavnaCijena.Text);
            double cijena = Double.Parse(tbProdajnaCijena.Text);
            int kolicina = Int32.Parse(tbKolicina.Text);

            if (cbPromet.Text.Equals("prodaja"))
                InstrumentProdajaController.Insert(new InstrumentProdaja(id, naziv, vrsta, godinaProizvodnje, nabavnaCijena, id, cijena, kolicina, kolicina));
            else if (cbPromet.Text.Equals("iznajmljivanje"))
                InstrumentIznajmljivanjeController.Insert(new InstrumentIznajmljivanje(id,naziv,vrsta,godinaProizvodnje,nabavnaCijena,id,cijena,kolicina,kolicina));
            this.Close();
        }

        private void cbPromet_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPromet.Text == "prodaja")
                lblCijena.Text = "Prodajna cijena";
            else
                lblCijena.Text = "Cijena iznajmljivanja";
        }
    }
}
