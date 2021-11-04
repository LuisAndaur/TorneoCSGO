using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    public class Exception_EdadInvalida : Exception
    {


        public Exception_EdadInvalida() : base()
        {

        }

        public Exception_EdadInvalida(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
