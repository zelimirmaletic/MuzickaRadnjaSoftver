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
    public partial class RazduzivanjeForm : Form
    {
        internal static int idZaposleni;
        internal static int idKlijent;
        internal static int idUgovor;
        internal static bool jeRazduzen = false;

        public RazduzivanjeForm()
        {
            InitializeComponent();
            loadDataGrid();
        }

        private void loadDataGrid()
        {

            List<string> list = RazduzivanjeInstrumentaController.ReadAllFormated();

            foreach (string obj in list)
            {
                
                var splitted = obj.Split('|');
                if(splitted[6].Equals("0"))
                {
                    DataGridViewRow drvr = (DataGridViewRow)dgvTabela.Rows[0].Clone();
                    drvr.Cells[0].Value = splitted[0];
                    drvr.Cells[1].Value = splitted[1];
                    drvr.Cells[2].Value = splitted[2];
                    drvr.Cells[3].Value = splitted[3];
                    drvr.Cells[4].Value = splitted[4];
                    drvr.Cells[5].Value = splitted[5];
                    drvr.Cells[6].Value = splitted[6];
                    dgvTabela.Rows.Add(drvr);
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvTabela.SelectedRows.Count==0)
                MessageBox.Show("Селектујете одговарајући ред.", "Грешка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                idUgovor = Int32.Parse(dgvTabela.SelectedRows[0].Cells[0].Value.ToString());
                idKlijent = Int32.Parse(dgvTabela.SelectedRows[0].Cells[]); 



                var form = new DetaljiRazduzivanjaForm();
                form.ShowDialog();
            }
        }
    }
}
