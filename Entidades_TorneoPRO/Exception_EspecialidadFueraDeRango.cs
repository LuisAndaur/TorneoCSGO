using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    public class Exception_EspecialidadFueraDeRango : Exception
    {


        public Exception_EspecialidadFueraDeRango() : base()
        {

        }

        public Exception_EspecialidadFueraDeRango(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
