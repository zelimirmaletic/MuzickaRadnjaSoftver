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
    public partial class SviInstrumentiForm : Form
    {
        public SviInstrumentiForm()
        {
            InitializeComponent();
            loadDataGrid();
        }
        private void loadDataGrid()
        {

            List<Instrument> list = InstrumentController.ReadAll();
            
            foreach(Instrument obj in list)
            {
                DataGridViewRow drvr = (DataGridViewRow)dgvTabela.Rows[0].Clone();
                drvr.Cells[0].Value = obj.Id.ToString();
                drvr.Cells[1].Value = obj.Naziv;
                drvr.Cells[2].Value = obj.Vrsta;
                drvr.Cells[3].Value = obj.GodinaProizvodnje.Year.ToString();
                drvr.Cells[4].Value = obj.NabavnaCijena.ToString();
                dgvTabela.Rows.Add(drvr);
            }
            
        }

        private void dgvTabela_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
