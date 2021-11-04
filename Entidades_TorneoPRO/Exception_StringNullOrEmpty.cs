using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    public class Exception_StringNullOrEmpty : Exception
    {

        public Exception_StringNullOrEmpty() : base()
        {
            
        }

        public Exception_StringNullOrEmpty(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
