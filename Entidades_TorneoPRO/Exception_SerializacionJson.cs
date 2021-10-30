using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    public class Exception_SerializacionJson : Exception
    {
        private string mensajeError;

        public Exception_SerializacionJson(string message) : base(message)
        {
            this.mensajeError = "Falla en la serializacion Json";
        }

        public Exception_SerializacionJson(string message, Exception innerException ) : base(message, innerException)
        {

        }

    }
}
