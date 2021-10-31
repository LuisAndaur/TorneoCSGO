using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades_TorneoPRO
{
    public class Exception_EspecialidadFueraDeRango : Exception
    {
        private string mensajeError;

        public Exception_EspecialidadFueraDeRango() : base()
        {
            this.mensajeError = "Especialidad fuera de rango definido por: XS-S-M-L-XL-XXL";
        }

        public Exception_EspecialidadFueraDeRango(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}
