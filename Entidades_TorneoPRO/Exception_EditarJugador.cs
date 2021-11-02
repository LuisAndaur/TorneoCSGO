using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    public class Exception_EditarJugador : Exception
    {
        private string mensajeError;

        public Exception_EditarJugador() : base()
        {
            this.mensajeError = "Falla en datos ingresados";
        }

        public Exception_EditarJugador(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
