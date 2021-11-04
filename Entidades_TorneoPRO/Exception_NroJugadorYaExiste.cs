using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    public class Exception_NroJugadorYaExiste : Exception
    {

        public Exception_NroJugadorYaExiste() : base()
        {

        }

        public Exception_NroJugadorYaExiste(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
