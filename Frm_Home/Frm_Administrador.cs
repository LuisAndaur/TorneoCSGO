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

        public Frm_Administrador()
        {
            InitializeComponent();
        }

        private void Frm_Administrador_Load(object sender, EventArgs e)
        {
            //listaJugadores = TorneoPro.ListaJugadores;
        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            //Frm_Home home = new Frm_Home();
            //home.Show();
            this.Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Frm_ModalABM agregar = new Frm_ModalABM();
            agregar.ShowDialog();
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            Frm_ModalABM editar = new Frm_ModalABM();
            editar.ShowDialog();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
