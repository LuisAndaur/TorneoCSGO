using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    class Exception_NroJugadorYaExiste : Exception
    {
        private string mensajeError;

        public Exception_NroJugadorYaExiste() : base()
        {
            this.mensajeError = "El nro de jugador ya existe";
        }

        public Exception_NroJugadorYaExiste(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
