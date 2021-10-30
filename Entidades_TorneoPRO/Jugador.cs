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

        public int Edad
        {
            get { return edad; }
            set
            {
                if (value > 11 && value <80)
                {
                    edad = value;
                }
                else
                {
                    throw new Exception_EdadInvalida();
                }
            }
        }

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

        public Jugador()
        {

        }
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
