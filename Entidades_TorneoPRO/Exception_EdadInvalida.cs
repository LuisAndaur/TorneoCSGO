using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    class Exception_EdadInvalida : Exception
    {
        private string mensajeError;

        public Exception_EdadInvalida() : base()
        {
            this.mensajeError = "Edad fuera de rango permitido";
        }

        public Exception_EdadInvalida(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
