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
    public partial class ListaRacunaForm : Form
    {
        public ListaRacunaForm()
        {
            InitializeComponent();
            loadDataGrid();
        }

        private void loadDataGrid()
        {

            List<string> list = RacunController.ReadAllFormated();

            foreach (string obj in list)
            {
                var splitted = obj.Split('|');
                DataGridViewRow drvr = (DataGridViewRow)dgvTabela.Rows[0].Clone();
                drvr.Cells[0].Value = splitted[0];
                drvr.Cells[1].Value = splitted[1];
                drvr.Cells[2].Value = splitted[2];
                drvr.Cells[3].Value = splitted[3];
                drvr.Cells[4].Value = splitted[4];
                drvr.Cells[5].Value = splitted[5];
                dgvTabela.Rows.Add(drvr);
            }

        }

        private void btnStampaj_Click(object sender, EventArgs e)
        {
            if (dgvTabela.SelectedRows.Count == 0)
            {
                MessageBox.Show("Molimo vas da selektujete racun!");
                return;
            }
            dataGridView1.Rows.Clear();
            int idRacuna = Int32.Parse(dgvTabela.SelectedRows[0].Cells[0].Value.ToString());
            var listaStavki = RacunImaInstrumentProdajaController.ReadAllFormated(idRacuna);

            for(int i = 0; i < listaStavki.Count; i++)
            {
                var splitted = listaStavki[i].Split('|');
                DataGridViewRow drvr = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                drvr.Cells[0].Value = splitted[0];
                drvr.Cells[1].Value = splitted[1];
                drvr.Cells[2].Value = splitted[2];
                drvr.Cells[3].Value = splitted[3];
                drvr.Cells[4].Value = splitted[4];
                drvr.Cells[5].Value = splitted[5];
                drvr.Cells[6].Value = splitted[6];
                drvr.Cells[7].Value = splitted[7];
                dataGridView1.Rows.Add(drvr);
            }

        }
    }
}
