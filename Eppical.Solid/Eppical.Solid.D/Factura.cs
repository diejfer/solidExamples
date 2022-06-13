using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eppical.Solid.D
{
    public class Factura : DocumentoContable
    {
        public Factura(int numero, DateTime fecha, double importe) : base(numero, fecha, importe)
        {
            _sigla = "FC";
        }

        public override double Total()
        {
            return this.Importe * 1.21;
        }

        public override string Imprimir()
        {
            return $"Factura {this.Numero} impresa correctamente";
        }

    }
}
