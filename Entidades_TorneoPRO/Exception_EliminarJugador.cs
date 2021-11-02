using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    public class Exception_EliminarJugador : Exception
    {
        private string mensajeError;

        public Exception_EliminarJugador() : base()
        {
            this.mensajeError = "Falla en eliminar jugador";
        }

        public Exception_EliminarJugador(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
