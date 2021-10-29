﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_TorneoPRO
{
    public partial class Frm_Home : Form
    {
        public Frm_Home()
        {
            InitializeComponent();
        }

        private void btn_AdministrarJugadores_Click(object sender, EventArgs e)
        {
            Frm_Administrador administrador = new Frm_Administrador();
            administrador.Show();
        }

        private void btn_Estadisticas_Click(object sender, EventArgs e)
        {
            Frm_Estadistica estadistica = new Frm_Estadistica();
            estadistica.Show();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {            
            Close();
        }

        private void Frm_Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }                
        }
    }
}