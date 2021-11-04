using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    public class Exception_EditarJugador : Exception
    {


        public Exception_EditarJugador() : base()
        {

        }

        public Exception_EditarJugador(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
