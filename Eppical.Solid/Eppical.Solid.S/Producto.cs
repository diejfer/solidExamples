using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eppical.Solid.S
{
    public class Producto
    {
        public string Descrip { get; set; }
        public double Precio { get; set; }

        public Producto(string descrip, double precio)
        {
            Descrip = descrip;
            Precio = precio;
        }

    }
}
