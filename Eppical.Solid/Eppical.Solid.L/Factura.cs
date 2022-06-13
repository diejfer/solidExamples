using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eppical.Solid.L
{
    public class Factura : Documento
    {

        public Factura(int numero, DateTime fecha) : base(numero, fecha)
        {
            this._sigla = "FC";
        }
    }
}
