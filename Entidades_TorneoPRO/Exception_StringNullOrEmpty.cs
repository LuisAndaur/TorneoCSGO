using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    class Exception_StringNullOrEmpty : Exception
    {
        private string mensajeError;

        public Exception_StringNullOrEmpty() : base()
        {
            this.mensajeError = "El campo nombre o nacionalidad esta vacio o es null";
        }

        public Exception_StringNullOrEmpty(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
