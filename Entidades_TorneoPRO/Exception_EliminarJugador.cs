using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    public class Exception_EliminarJugador : Exception
    {


        public Exception_EliminarJugador() : base()
        {

        }

        public Exception_EliminarJugador(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
