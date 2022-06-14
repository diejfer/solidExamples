using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eppical.Solid.D
{
    #region Good

    //public class Municipal : Impuesto
    //{
    //    public string Partida { get; set; }
    //    public Municipal(double importe, string partida) : base(importe)
    //    {
    //        this.Partida = partida;
    //    }

    //    public override string Imprimir()
    //    {
    //        return $"Impuesto Municipal Partida {this.Partida} impreso correctamente";
    //    }
    //}

    #endregion

    #region Bad

    public class Municipal : Impuesto
    {
        public string Partida { get; set; }
        public Municipal(double importe, string partida) : base(importe)
        {
            this.Partida = partida;
        }

    }

    #endregion
}
