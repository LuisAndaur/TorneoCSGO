using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    class Exception_GeneroInvalido : Exception
    {
        private string mensajeError;

        public Exception_GeneroInvalido() : base()
        {
            this.mensajeError = "Genero no valido";
        }

        public Exception_GeneroInvalido(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
