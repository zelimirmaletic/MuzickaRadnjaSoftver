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
    public partial class ListaMaloprodajnihInstrumenata : Form
    {
        public ListaMaloprodajnihInstrumenata()
        {
            InitializeComponent();
            loadDataGrid();
        }

        private void loadDataGrid()
        {

            List<InstrumentProdaja> list = InstrumentProdajaController.ReadAll();

            foreach (var obj in list)
            {
                
                DataGridViewRow drvr = (DataGridViewRow)dgvTabela.Rows[0].Clone();
                drvr.Cells[0].Value = obj.Id.ToString();
                drvr.Cells[1].Value = obj.Naziv;
                drvr.Cells[2].Value = obj.Vrsta;
                drvr.Cells[3].Value = obj.GodinaProizvodnje.Year.ToString();
                drvr.Cells[4].Value = obj.NabavnaCijena.ToString();
                drvr.Cells[5].Value = obj.MaloprodajnaCijena.ToString();
                drvr.Cells[6].Value = (obj.MaloprodajnaCijena + obj.MaloprodajnaCijena * Main.PDV).ToString("0.00");
                drvr.Cells[7].Value = obj.DostupnaKolicina.ToString();
                dgvTabela.Rows.Add(drvr);
            }

        }

    }
}
