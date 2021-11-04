using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    public class Exception_SerializacionXml : Exception
    {


        public Exception_SerializacionXml(string message) : base(message)
        {

        }

        public Exception_SerializacionXml(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
