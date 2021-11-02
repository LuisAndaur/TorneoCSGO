using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    public class Jugador
    {
        private int nroJugador;
        private string nombre;
        private int edad;
        private string genero;
        private string nacionalidad;
        private string especialidad;
        private bool primerTorneo;
        private Estadistica eJugador;

        /// <summary>
        /// Propiedad numero identificador del jugador
        /// </summary>
        public int NroJugador
        {
            get { return nroJugador; }
            set
            {
                if (value > 0)
                {
                    nroJugador = value;
                }
            }
        }

        /// <summary>
        /// Propiedad nombre del jugador
        /// </summary>
        /// <exception cref="Exception_StringNullOrEmpty">Error si el nombre viene vacio o null</exception>
        public string Nombre
        {
            get { return nombre; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    nombre = value;
                }
                else
                {
                    throw new Exception_StringNullOrEmpty();
                }
            }
        }

        /// <summary>
        /// Propiedad edad del jugador
        /// </summary>
        /// <exception cref="Exception_EdadInvalida">Error si la edad esta fuera de rango</exception>
        public int Edad
        {
            get { return edad; }
            set
            {
                if (value > 11 && value < 80)
                {
                    edad = value;
                }
                else
                {
                    throw new Exception_EdadInvalida();
                }
            }
        }

        /// <summary>
        /// Propiedad genero del jugador
        /// </summary>
        /// <exception cref="Exception_GeneroInvalido">Error si el genero es incorrecto</exception>
        public string Genero
        {
            get { return genero; }
            set
            {
                if (value.Trim() == "Female" || value.Trim() == "Male")
                {
                    genero = value;
                }
                else
                {
                    throw new Exception_GeneroInvalido();
                }
            }
        }

        /// <summary>
        /// Propiedad nacionalidad del jugador
        /// </summary>
        /// <exception cref="Exception_StringNullOrEmpty">Error si la nacionalidad viene vacio o null</exception>
        public string Nacionalidad
        {
            get { return nacionalidad; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    nacionalidad = value;
                }
                else
                {
                    throw new Exception_StringNullOrEmpty();
                }
            }
        }

        /// <summary>
        /// Propiedad Especialidad del jugador
        /// </summary>
        /// <exception cref="Exception_EspecialidadFueraDeRango">Error si la especialidad no es correcta</exception>
        public string Especialidad
        {
            get { return especialidad; }
            set 
            {
                if (value == "XS" || value == "S" || value == "M" || value == "L" || value == "XL" || value == "XXL")
                {
                    especialidad = value;
                }
                else
                {
                    throw new Exception_EspecialidadFueraDeRango();
                }
            }
        }

        /// <summary>
        /// Propiedad Primer Torneo del jugador
        /// </summary>
        public bool PrimerTorneo
        {
            get { return primerTorneo; }
            set
            {
                if (value || !value)
                {
                    primerTorneo = value;
                }
            }
        }

        /// <summary>
        /// Estadisticas del jugador
        /// </summary>
        public Estadistica Estadistica 
        {
            get {return eJugador; }
            set {this.eJugador = value; } 
        }

        /// <summary>
        /// Constructor de jugador por defecto vacio
        /// </summary>
        public Jugador()
        {

        }

        /// <summary>
        /// Constructor jugador con parametros
        /// </summary>
        /// <param name="nroJugador">Nro identificador jugador</param>
        /// <param name="nombre">nombre jugador></param>
        /// <param name="edad">edad del jugador</param>
        /// <param name="genero">genero del jugador</param>
        /// <param name="nacionalidad">acionalidad del jugador</param>
        /// <param name="especialidad">especialidad del jugador</param>
        /// <param name="primerTorneo">primer torneo del jugador</param>
        public Jugador(int nroJugador, string nombre, int edad, string genero, string nacionalidad, string especialidad, bool primerTorneo) : this()
        {
            this.NroJugador = nroJugador;
            this.Nombre = nombre;
            this.Edad = edad;
            this.Genero = genero;
            this.Nacionalidad = nacionalidad;
            this.especialidad = especialidad;
            this.PrimerTorneo = primerTorneo;
            this.eJugador = new Estadistica();
        }

        

    }
}
