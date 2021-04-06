﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MuzickaRadnja
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void hideSubmenu()
        {
            if (PanelInstrumentiSubMenu.Visible == true)
                PanelInstrumentiSubMenu.Visible = false;
            if (PanelMaloprodajaSubMenu.Visible == true)
                PanelMaloprodajaSubMenu.Visible = false;
            if (PanelIznajmljivanje.Visible == true)
                PanelIznajmljivanje.Visible = false;
        }

        private void showSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;//Ciklicno...
            }
        }

        private void btnInstrumentMenu_Click(object sender, EventArgs e)
        {
            showSubmenu(PanelInstrumentiSubMenu);
        }

        private void btnProdajaSideMenu_Click(object sender, EventArgs e)
        {
            showSubmenu(PanelMaloprodajaSubMenu);
        }

        private void btnIznajmljivanjeSideMenu_Click(object sender, EventArgs e)
        {
            showSubmenu(PanelIznajmljivanje);
        }
    }
}