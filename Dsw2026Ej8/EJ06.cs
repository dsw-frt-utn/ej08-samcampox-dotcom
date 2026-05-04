using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class EJ06
    {
        public string NormalizarCodigoProducto(string codigo)
        {
            string message;
            message=codigo.ToProductCode();

            return message;
        }
    }
}
