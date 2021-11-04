using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    public class Exception_Archivo : Exception
    {


        public Exception_Archivo(string message) : base(message)
        {

        }

        public Exception_Archivo(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
