using System;
using System.Collections.Generic;

namespace Entidades_TorneoPRO
{
    public static class TorneoPro
    {
        private static string nombreTorneo;
        private static double premio;
        private static string patrocinio;
        private static List<Jugador> listaJugadores;

        public static List<Jugador> ListaJugadores
        {
            get { return listaJugadores; }
            set 
            { 
                if (value != null)
                {
                   listaJugadores = value;
                }
            }
        }

        public static string Patrocinio
        {
            get { return patrocinio; }
        }

        public static double Premio
        {
            get { return premio; }
        }

        public static string NombreTorneo
        {
            get { return nombreTorneo; }
        }

        static TorneoPro()
        {
            nombreTorneo = "TorneoPRO : CSGO";
            premio = 1000000;
            patrocinio = "EASport";
            listaJugadores = new List<Jugador>();
            CargarJugadores();
        }

        private static void CargarJugadores()
        {
            listaJugadores = SerializacionJson<List<Jugador>>.LeerInicial("listaJugadores.json");
        }

        public static bool ExisteJugador(int numero)
        {
            foreach (Jugador item in listaJugadores)
            {
                if (item.NroJugador == numero)
                {
                    return true;
                }
            }
            return false;
        }

        public static void AgregarJugador(string nroJugador, string nombre, string edad, string genero, string nacionalidad, string especialidad, bool primerTorneo)
        {
            if (!string.IsNullOrEmpty(nroJugador) && !string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(edad) && !string.IsNullOrEmpty(genero) && !string.IsNullOrEmpty(nacionalidad) && !string.IsNullOrEmpty(especialidad))
            {
                int.TryParse(nroJugador, out int auxNroJugador);
                if (ExisteJugador(auxNroJugador))
                {
                    throw new Exception_NroJugadorYaExiste();
                }
                int.TryParse(edad, out int auxEdad);                

                listaJugadores.Add(new Jugador(auxNroJugador, nombre, auxEdad, genero, nacionalidad, especialidad, primerTorneo));
            }
            else
            {
                throw new Exception_ErrorAgregarJugador();
            }            
        }
    }
}
