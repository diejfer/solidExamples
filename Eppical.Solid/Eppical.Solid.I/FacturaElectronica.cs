using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eppical.Solid.I
{
    #region Good

    public class FacturaElectronica : Documento, IEmaileable
    {
        public string CAE { get; set; }

        public FacturaElectronica(int numero, DateTime fecha) : base(numero, fecha)
        {
        }

        public string EnviarPorEmail()
        {
            return $"Factura electrónica {this.Numero} enviada correctamente";
        }

        public override string Imprimir()
        {
            return $"Factura electrónica {this.Numero} impresa correctamente";
        }
    }

    #endregion

    #region Bad
    //public class FacturaElectronica : Documento
    //{
    //    public string CAE { get; set; }
    //    public FacturaElectronica(int numero, DateTime fecha) : base(numero, fecha)
    //    {
    //    }

    //    public override string EnviarPorEmail()
    //    {
    //        return $"Factura electrónica {this.Numero} enviada correctamente";
    //    }


    //    public override string Imprimir()
    //    {
    //        return $"Factura electrónica {this.Numero} impresa correctamente";
    //    }
    //}

    #endregion

}
