using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eppical.Solid.D
{
    #region Good
    //public class NotaCredito : DocumentoContable
    //{
    //    public NotaCredito(int numero, DateTime fecha, double importe) : base(numero, fecha, importe)
    //    {
    //        _sigla = "NC";
    //    }

    //    public override double Total()
    //    {
    //        return this.Importe * 1.21 * -1;
    //    }

    //    public override string Imprimir()
    //    {
    //        return $"Nota de Crédito {this.Numero} impresa correctamente";
    //    }

    //}

    #endregion

    #region Bad

    public class NotaCredito : DocumentoContable
    {
        public NotaCredito(int numero, DateTime fecha, double importe) : base(numero, fecha, importe)
        {
            _sigla = "NC";
        }

        public override double Total()
        {
            return this.Importe * 1.21 * -1;
        }

    }

    #endregion

}
