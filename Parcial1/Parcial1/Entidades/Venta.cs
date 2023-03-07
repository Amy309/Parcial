using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1.Entidades
{
    public class Venta
    {
        public int IdentificadorDeProducto { get; set; }
        public string? NombreDelProducto { get; set; }
        public string? DescripcionDelProducto { get; set; }
        public double PrecioDelProducto { get; set; }
        public int CantidadDeProducto { get; set; }
        public int Descontar { get; set; }
    }
}
