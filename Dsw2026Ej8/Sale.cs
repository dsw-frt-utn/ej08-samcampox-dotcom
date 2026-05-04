using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Dsw2026Ej8
{
    public class Sale
    {
        public decimal importe { get; set }
        public virtual decimal CalculateTotal()
        {
            return importe;
           
        }
    }
}
