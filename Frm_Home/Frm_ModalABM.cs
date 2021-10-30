using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades_TorneoPRO;

namespace Frm_TorneoPRO
{
    public partial class Frm_ModalABM : Form
    {
        Jugador auxJugador = new Jugador(); 
        string tipo = string.Empty;

        public Frm_ModalABM()
        {
            InitializeComponent();
        }

        private void Frm_ModalABM_Load(object sender, EventArgs e)
        {
            if (tipo == "agregar")
            {
                lbl_Titulo.Text = "Menu agregar jugador";
                btn_Editar.Visible = false;
                txt_NroJugador.ReadOnly = false;
            }
            else
            {
                lbl_Titulo.Text = "Menu editar jugador";
                btn_Agregar.Enabled = false;                
                txt_NroJugador.Text = auxJugador.NroJugador.ToString();
                txt_Nombre.Text = auxJugador.Nombre;
                cmb_Genero.Text = auxJugador.Genero;
                txt_Edad.Text = auxJugador.Edad.ToString();
                txt_Nacionalidad.Text = auxJugador.Nacionalidad;
                cmb_Especialidad.Text = auxJugador.Especialidad;
                ckb_PrimerTorneo.Checked = auxJugador.PrimerTorneo;
            }
        }

        public Frm_ModalABM(string tipo) : this()
        {
            this.tipo = tipo;
        }

        public Frm_ModalABM(string tipo, Jugador jugador) : this()
        {
            this.tipo = tipo;
            this.auxJugador = jugador;            
        }
        

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {

                this.Close();
            }
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {
                this.Close();
            }
        }

        /// <summary>
        /// Permite ingresar solo letras
        /// </summary>
        /// <param name="e"></param>
        private void SoloLetras(KeyPressEventArgs e)
        {
            if ((e.KeyChar > 31 && e.KeyChar < 65) || (e.KeyChar > 90 && e.KeyChar < 97) || (e.KeyChar > 122 && e.KeyChar < 256))
            {
                MessageBox.Show("Sólo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        /// <summary>
        /// Permite ingresar solo numeros
        /// </summary>
        /// <param name="e"></param>
        private void SoloNumeros(KeyPressEventArgs e)
        {
            if ((e.KeyChar > 31 && e.KeyChar < 48) || (e.KeyChar > 57 && e.KeyChar < 256))
            {
                MessageBox.Show("Sólo números", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
            }
        }

        private void txt_NroJugador_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }

        private void txt_Edad_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txt_Nacionalidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }
    }
}
