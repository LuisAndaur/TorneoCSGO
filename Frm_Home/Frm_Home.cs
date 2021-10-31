using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frm_TorneoPRO
{
    public partial class Frm_Home : Form
    {
        private SoundPlayer sonidoEntradaCarga;
        public Frm_Home()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Precarga de metodos antes de abrir el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Home_Load(object sender, EventArgs e)
        {
            SonidoAmbiente();
        }

        /// <summary>
        /// Lanza un form para administrar a los jugadores ABM
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AdministrarJugadores_Click(object sender, EventArgs e)
        {
            Frm_Administrador administrador = new Frm_Administrador();
            this.Hide();
            administrador.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Lanza un form con las estadisticas del torneo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Estadisticas_Click(object sender, EventArgs e)
        {
            Frm_Estadistica estadistica = new Frm_Estadistica();
            this.Hide();
            estadistica.ShowDialog();
            this.Show();
        }

        /// <summary>
        /// Cierra la app por completo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Salir_Click(object sender, EventArgs e)
        {            
            Close();
        }

        /// <summary>
        /// Antes de cerrar pregunta si realmente deseamos cerrar la app
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Frm_Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }                
        }        

        /// <summary>
        /// Carga la musica de fondo y la mantiene en loop
        /// </summary>
        public void SonidoAmbiente()
        {
            sonidoEntradaCarga = new SoundPlayer($"{Environment.CurrentDirectory}\\csgo-fondohome.wav");
            sonidoEntradaCarga.PlayLooping();
        }

 
    }
}
