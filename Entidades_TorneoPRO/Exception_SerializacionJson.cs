using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    public class Exception_SerializacionJson : Exception
    {


        public Exception_SerializacionJson(string message) : base(message)
        {

        }

        public Exception_SerializacionJson(string message, Exception innerException ) : base(message, innerException)
        {

        }

    }
}
