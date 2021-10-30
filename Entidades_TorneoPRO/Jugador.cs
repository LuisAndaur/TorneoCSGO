using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    public class Jugador
    {
        private int id;
        private string nombre;
        private int edad;
        private string genero;
        private string nacionalidad;
        private string especialidad;
        private bool primerTorneo;

        public enum EGenero
        {
            Male, Female
        }

        public enum EEspecialidad
        {
            XS, S, M, L, XL, XXL
        }

        public int Id
        {
            get { return id; }
            set
            {
                if (value > 0)
                {
                    id = value;
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
            }
        }

        public int Edad
        {
            get { return edad; }
            set
            {
                if (value > 11)
                {
                    edad = value;
                }
            }
        }

        public string Genero
        {
            get { return genero; }
            set
            {
                //if (value == EGenero.Female || value == EGenero.Male)
                //{
                genero = value;
                //}                
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
            }
        }        

        public string Especialidad
        {
            get { return especialidad; }
            set 
            {
                //if (value == EDistancia.XS || value == EDistancia.S 
                //    || value == EDistancia.M || value == EDistancia.L 
                //    || value == EDistancia.XL || value == EDistancia.XXL)
                //{
                especialidad = value;
                //}
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

        public Jugador(int id, string nombre, int edad, string genero, string nacionalidad, string especialidad, bool primerTorneo)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Edad = edad;
            this.Genero = genero;
            this.Nacionalidad = nacionalidad;
            this.especialidad = especialidad;
            this.PrimerTorneo = primerTorneo;
        }
    }
}
