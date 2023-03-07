using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial1.Entidades;

namespace Parcial1.Negocio
{
    public class ClsVenta
    {
        public String Cobro(Venta venta)
        {
            double Descuento = venta.PrecioDelProducto * venta.CantidadDeProducto;

            if (Descuento > 50)
            {
                venta.Descontar = (int)(Descuento - 10);
                return ($"Su total a pagar con descuento es {venta.Descontar}");
            }
            else
            {
                return ($"Total a pagar {Descuento}");
            }
        }
    }
}
