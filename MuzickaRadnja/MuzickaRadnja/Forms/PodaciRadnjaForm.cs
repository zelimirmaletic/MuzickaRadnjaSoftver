using MuzickaRadnja.Data.Controller;
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
    public partial class PodaciRadnjaForm : Form
    {
        public PodaciRadnjaForm()
        {
            InitializeComponent();
            ucitajPodatke();
        }

        private void ucitajPodatke()
        {
            var radnja = RadnjaController.Read(1);
            var podaci = radnja.Split('|');
            tbMjesto.Text = podaci[1];
            tbNaziv.Text = podaci[2];
            tbAdresa.Text = podaci[3];
            tbRacun.Text = podaci[4];
            tbBanka.Text = podaci[5];
            tbEmail.Text = podaci[6];
            tbTelefon.Text = podaci[7];
        }
    }
}
