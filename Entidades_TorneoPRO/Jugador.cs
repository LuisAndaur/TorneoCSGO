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
        private EGenero genero;
        private string nacionalidad;
        private EDistancia expertoDistancia;
        private bool primeraParticipacion;

        public enum EGenero
        {
            Male, Female
        }

        public enum EDistancia
        {
            XS, S, M, L, XL, XXL
        }

        public bool PrimeraParticipacion
        {
            get { return primeraParticipacion; }
            set 
            {
                if (value || !value)
                {
                    primeraParticipacion = value;
                }
            }
        }

        public EDistancia ExpertoDistancia
        {
            get { return expertoDistancia; }
            set 
            {
                if (value == EDistancia.XS || value == EDistancia.S 
                    || value == EDistancia.M || value == EDistancia.L 
                    || value == EDistancia.XL || value == EDistancia.XXL)
                {
                    expertoDistancia = value;
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
            }
        }

        public EGenero Genero
        {
            get { return genero; }
            set 
            {
                if (value == EGenero.Female || value == EGenero.Male)
                {
                    genero = value;
                }                
            }
        }

        public int Edad
        {
            get { return edad; }
            set 
            {
                if (value > 12)
                {
                    edad = value;
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

        //public Jugador()
        //{

        //}
        public Jugador(int id, string nombre, int edad, EGenero genero, string nacionalidad, EDistancia expertoDistancia, bool primeraParticipacion) 
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Edad = edad;
            this.Genero = genero;
            this.Nacionalidad = nacionalidad;
            this.ExpertoDistancia = expertoDistancia;
            this.PrimeraParticipacion = primeraParticipacion;
        }
    }
}
