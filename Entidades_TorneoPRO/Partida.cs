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
        private int headshot;
        private int bomba;
        private int rehenes;

        public Partida()
        {
            this.listaJugadores = TorneoPro.ListaJugadores;
            this.mapasDeathmatch = TorneoPro.MapasDeathmatch;
            this.mapasBomba = TorneoPro.MapasBomba;
            this.mapasRehenes = TorneoPro.MapasRehenes;
            random = new Random();
        }

        public void SimularPartidas()
        {
            Random random = new Random();
            kills = random.Next(0, 50);
            muertes = random.Next(0, 50);


            if (golesLocal < golesVisitante)
            {
                equipoLocal.Estadistica.Actualizar(EResultado.Derrota, golesLocal, golesVisitante);
                equipoVisitante.Estadistica.Actualizar(EResultado.Victoria, golesVisitante, golesLocal);
            }
            else
            {
                if (golesLocal > golesVisitante)
                {
                    equipoLocal.Estadistica.Actualizar(EResultado.Victoria, golesLocal, golesVisitante);
                    equipoVisitante.Estadistica.Actualizar(EResultado.Derrota, golesVisitante, golesLocal);
                }
                else
                {
                    equipoLocal.Estadistica.Actualizar(EResultado.Empate, golesLocal, golesVisitante);
                    equipoVisitante.Estadistica.Actualizar(EResultado.Empate, golesVisitante, golesLocal);
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
            return random.Next(0, 3);
        }

        /// <summary>
        /// Calcula rehenes rescatados por jugador
        /// </summary>
        /// <returns>cantidad random</returns>
        public int RehenesRescatados()
        {
            return random.Next(0, 2);
        }

        private void MapasPlantaBombas()
        {
            kills = random.Next(0, 50);
            muertes = random.Next(0, 50);

            foreach (Bomba mBomba in mapasBomba)
            {
                foreach (Jugador auxJugador in listaJugadores)
                {
                    auxJugador.Estadistica.Actualizar();
                }
            }
        }
    }
}
