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

        /// <summary>
        /// Propiedad estatica de la lista de jugadores
        /// </summary>
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

        /// <summary>
        /// Propiedad estatica readonly del patrocinador del torneo
        /// </summary>
        public static string Patrocinio
        {
            get { return patrocinio; }
        }

        /// <summary>
        /// Propiedad estatica readonly del premio del torneo
        /// </summary>
        public static double Premio
        {
            get { return premio; }
        }

        /// <summary>
        /// Propiedad estatica readonly del nombre del torneo
        /// </summary>
        public static string NombreTorneo
        {
            get { return nombreTorneo; }
        }

        /// <summary>
        /// Constructor estatico de la clase TorneoPro
        /// </summary>
        static TorneoPro()
        {
            nombreTorneo = "TorneoPRO : CSGO";
            premio = 1000000;
            patrocinio = "EASport";
            listaJugadores = new List<Jugador>();
            CargarJugadores();
        }

        /// <summary>
        /// Metodo que carga la lista de jugadores desde un archivo json
        /// </summary>
        private static void CargarJugadores()
        {
            listaJugadores = SerializacionJson<List<Jugador>>.LeerInicial("listaJugadores.json");
        }

        /// <summary>
        /// Metodo que chequea en la lista de jugadores si existe el numero de jugador
        /// </summary>
        /// <param name="numero"></param>
        /// <returns>True si existe el numero o false si no</returns>
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

        /// <summary>
        /// Agrega un jugador a la lista si cumple las caracteristicas
        /// </summary>
        /// <param name="nroJugador">Nro del jugador</param>
        /// <param name="nombre">Nombre del jugador</param>
        /// <param name="edad">Edad del jugador</param>
        /// <param name="genero">Genero del jugador</param>
        /// <param name="nacionalidad">Nacionalidad del jugador</param>
        /// <param name="especialidad">Especialidad del jugador</param>
        /// <param name="primerTorneo">False si ya jugo el torneo o true si es la primera vez</param>
        /// <exception cref="Exception_NroJugadorYaExiste">Error si el numero identificador ya existe</exception>
        /// <exception cref="Exception_ErrorAgregarJugador">Error si no se puedo cargar al jugador</exception>
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


        public static void EditarJugador()
        {

        }

        public static void EliminarJugador()
        {

        }
    }
}
