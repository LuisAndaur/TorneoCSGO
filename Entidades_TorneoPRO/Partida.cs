using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    public class Partida : IAwp, IBomba, IRehenes
    {
        private List<Jugador> listaJugadores = new List<Jugador>();
        private List<Deathmatch> mapasDeathmatch = new List<Deathmatch>();
        private List<Bomba> mapasBomba = new List<Bomba>();
        private List<Rehenes> mapasRehenes = new List<Rehenes>();
        Random random;
        private int kills;
        private int muertes;

        public static List<Jugador> Jugadores { get { return TorneoPro.ListaJugadores; } }

        public Partida()
        {
            this.listaJugadores = TorneoPro.ListaJugadores;
            this.mapasDeathmatch = TorneoPro.MapasDeathmatch;
            this.mapasBomba = TorneoPro.MapasBomba;
            this.mapasRehenes = TorneoPro.MapasRehenes;
            random = new Random();
        }

        /// <summary>
        /// Simula todas las partidas del torneo
        /// </summary>
        public void SimularPartidas()
        {
            foreach (Bomba mBomba in mapasBomba)
            {
                foreach (Jugador auxJugador in listaJugadores)
                {
                    kills = random.Next(0, 30);
                    muertes = random.Next(0, 30);
                    auxJugador.Estadistica.Actualizar(kills, muertes, 0, BombasPlantadas(), 0);
                    mBomba.Estadistica.Actualizar(kills, muertes, 0, BombasPlantadas(), 0);                    
                }                
            }

            foreach (Deathmatch mDeathmatch in mapasDeathmatch)
            {
                foreach (Jugador auxJugador in listaJugadores)
                {
                    kills = random.Next(0, 30);
                    muertes = random.Next(0, 30);
                    auxJugador.Estadistica.Actualizar(kills, muertes, CantidadHeadshot(), 0, 0);
                    mDeathmatch.Estadistica.Actualizar(kills, muertes, CantidadHeadshot(), 0, 0);
                }
            }

            foreach (Rehenes mRehenes in mapasRehenes)
            {
                foreach (Jugador auxJugador in listaJugadores)
                {
                    kills = random.Next(0, 30);
                    muertes = random.Next(0, 30);
                    auxJugador.Estadistica.Actualizar(kills, muertes, 0, 0, RehenesRescatados());
                    mRehenes.Estadistica.Actualizar(kills, muertes, 0, 0, RehenesRescatados());
                }
            }

        }

        /// <summary>
        /// Calcula muertes por headshot por jugador
        /// </summary>
        /// <returns>cantidad random</returns>
        public int CantidadHeadshot()
        {
            return random.Next(0, 20);
        }

        /// <summary>
        /// Calcula bombas plantadas por jugador
        /// </summary>
        /// <returns>cantidad random</returns>
        public int BombasPlantadas()
        { 
            return random.Next(0, 4); ;
        }

        /// <summary>
        /// Calcula rehenes rescatados por jugador
        /// </summary>
        /// <returns>cantidad random</returns>
        public int RehenesRescatados()
        {
            return random.Next(0, 3);
        }

        //public override string ToString()
        //{
        //    StringBuilder jugador = new StringBuilder();

        //    foreach (Jugador item in listaJugadores)
        //    {
        //        jugador.AppendLine($"Nro: {item.NroJugador}");
        //        jugador.AppendLine($"Nombre: {item.Nombre}");
        //        jugador.AppendLine($"Genero: {item.Genero}");
        //        jugador.AppendLine($"Nacionalidad: {item.Nacionalidad}");
        //        jugador.AppendLine($"Especialidad: {item.Especialidad}");
        //        jugador.AppendLine($"Primer Torneo: {item.PrimerTorneo}");
        //        jugador.AppendLine($"Puntos: {item.Estadistica.Puntos}");
        //        jugador.Append($" Kills: {item.Estadistica.Kills}");
        //        jugador.Append($" Muertes: {item.Estadistica.Muerte}");
        //        jugador.Append($" Headshot: {item.Estadistica.Headshot}");
        //        jugador.Append($" Bomba: {item.Estadistica.Bombas}");
        //        jugador.AppendLine($" Rehenes: {item.Estadistica.Rehenes}");
        //        jugador.AppendLine($"--------------------------------------");
        //    }

        //    return jugador.ToString();
        //}
    }
}
