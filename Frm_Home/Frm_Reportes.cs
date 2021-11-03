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
    public partial class Frm_Reportes : Form
    {
        public Frm_Reportes()
        {
            InitializeComponent();
        }

        private void Frm_Estadistica_Load(object sender, EventArgs e)
        {

        }

        private void btn_Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Campeon_Click(object sender, EventArgs e)
        {
            try
            {
                SerializacionJson<Jugador>.Escribir(Jugador.Campeon(), "CampeonDelTorneo");
                Archivo.Escribir(Jugador.Campeon().ToString(), "CampeonDelTorneo");
                SerializacionXml<Jugador>.Escribir(Jugador.Campeon(), "CampeonDelTorneo");
            }
            catch (Exception_SerializacionJson eSerializacion)
            {
                MessageBox.Show(eSerializacion.Message, "ERROR al cargar la lista json", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception auxEx)
            {
                MessageBox.Show(auxEx.Message, "Error inesperado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btn_EstadisticaJugadores_Click(object sender, EventArgs e)
        {
            Archivo.Escribir(TorneoPro.Imprimir(TorneoPro.ListaJugadores), "EstadisticasJugadores");
            SerializacionJson<List<Jugador>>.Escribir(TorneoPro.ListaJugadores, "jugarJson");
        }
    }
}
