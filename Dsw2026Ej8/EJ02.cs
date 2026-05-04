using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public class problema2
    {
        public string CrearResumenVenta (long productCode, string productDescription, int quantity, decimal uniPrice)
        {
            decimal total = 0;
            if (quantity > 0)
            {
                total = quantity * uniPrice;
            } 
            else
            {
                total = 0;
            }
            var venta = new { Code = productCode, Description = productDescription, Quantity = quantity, Total = total };
            return $"{venta.Code}-{venta.Description}-{venta.Total}";
        }
    }
}
