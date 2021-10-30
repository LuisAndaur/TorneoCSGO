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
    public partial class Frm_Administrador : Form
    {
        List<Jugador> listaJugadores = new List<Jugador>();
        Jugador auxJugador = new Jugador();
        private int indice = 0;

        public Frm_Administrador()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Pre carga del formulario administrador que hace cargar la lista de jugadores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="Exception_SerializacionJson">Error en serializacion o deserializacion de un json</exception>
        private void Frm_Administrador_Load(object sender, EventArgs e)
        {
            try
            {
                listaJugadores = TorneoPro.ListaJugadores;
                dgv_ListaJugadores.Rows.Clear();
                dgv_ListaJugadores.DataSource = listaJugadores;
            }
            catch (Exception_SerializacionJson ex)
            {
                throw new Exception_SerializacionJson("ERROR al cargar la lista",ex);
            }
            catch (Exception auxEx)
            {
                throw new Exception("Error inesperado", auxEx);
            }
            
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Frm_ModalABM agregar = new Frm_ModalABM("agregar");
            agregar.ShowDialog();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            if (auxJugador.NroJugador > 0)
            {
                Frm_ModalABM editar = new Frm_ModalABM("editar", auxJugador);
                editar.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione el jugador que quiere editar", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }            
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {

        }

        private void dgv_ListaJugadores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = e.RowIndex;
            if (indice != -1)
            {
                auxJugador.NroJugador = (int)dgv_ListaJugadores.Rows[indice].Cells[0].Value;
                auxJugador.Nombre = dgv_ListaJugadores.Rows[indice].Cells[1].Value.ToString();
                auxJugador.Edad = (int)dgv_ListaJugadores.Rows[indice].Cells[2].Value;
                auxJugador.Genero = dgv_ListaJugadores.Rows[indice].Cells[3].Value.ToString();
                auxJugador.Nacionalidad = dgv_ListaJugadores.Rows[indice].Cells[4].Value.ToString();
                auxJugador.Especialidad = dgv_ListaJugadores.Rows[indice].Cells[5].Value.ToString();
                auxJugador.PrimerTorneo = (bool)dgv_ListaJugadores.Rows[indice].Cells[6].Value;
            }
        }
    }
}
