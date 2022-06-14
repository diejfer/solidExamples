using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eppical.Solid.I
{
    #region Good

    //public class Factura : Documento
    //{
    //    public string CAI { get; set; }

    //    public Factura(int numero, DateTime fecha) : base(numero, fecha)
    //    {
    //    }

    //    public override string Imprimir()
    //    {
    //        return $"Factura {this.Numero} impresa correctamente";
    //    }
    //}

    #endregion

    #region Bad

    public class Factura : Documento
    {
        public string CAI { get; set; }
        public Factura(int numero, DateTime fecha) : base(numero, fecha)
        {
        }

        public override string EnviarPorEmail()
        {
            throw new InvalidOperationException("Operación no válida para Facturas");
        }

        public override string Imprimir()
        {
            return $"Factura {this.Numero} impresa correctamente";
        }
    }

    #endregion
}
