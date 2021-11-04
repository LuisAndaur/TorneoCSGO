using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    public class Exception_GeneroInvalido : Exception
    {


        public Exception_GeneroInvalido() : base()
        {

        }

        public Exception_GeneroInvalido(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
