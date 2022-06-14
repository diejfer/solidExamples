using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eppical.Solid.D
{
    #region Good

    //public class FacturaLuz : Impuesto
    //{
    //    public string CodigoPago { get; set; }
    //    public FacturaLuz(double importe, string codigoPago) : base(importe)
    //    {
    //        this.CodigoPago = codigoPago;
    //    }

    //    public override string Imprimir()
    //    {
    //        return $"Factura de Luz Código {this.CodigoPago} impresa correctamente";
    //    }
    //}

    #endregion

    #region Bad

    public class FacturaLuz : Impuesto
    {
        public string CodigoPago { get; set; }
        public FacturaLuz(double importe, string codigoPago) : base(importe)
        {
            this.CodigoPago = codigoPago;
        }

    }

    #endregion
}
