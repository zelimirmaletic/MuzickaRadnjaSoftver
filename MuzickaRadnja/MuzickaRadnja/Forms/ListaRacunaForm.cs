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


    }
}
