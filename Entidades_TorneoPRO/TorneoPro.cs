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
            SerializacionJson<List<Jugador>>.LeerInicial("listaJugadores.json");
        }

    }
}
