using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eppical.Solid.D
{
    #region Good

    //public abstract class Impuesto : IImprimible
    //{
    //    public double Importe { get; set; }
    //    public Impuesto(double importe)
    //    {
    //        this.Importe = importe;
    //    }

    //    public abstract string Imprimir();

    //}

    #endregion

    #region Bad

    public abstract class Impuesto
    {
        public double Importe { get; set; }
        public Impuesto(double importe)
        {
            this.Importe = importe;
        }

    }

    #endregion
}
