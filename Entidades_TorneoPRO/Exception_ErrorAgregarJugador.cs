using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    public class Exception_ErrorAgregarJugador : Exception
    {

        public Exception_ErrorAgregarJugador() : base()
        {

        }

        public Exception_ErrorAgregarJugador(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
