using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eppical.Solid.L
{
    #region Good

    //public class Impresora
    //{
    //    public string Imprimir(Documento documento)
    //    {
    //        return documento.Imprimir();
    //    }

    //    public string ImprimirRemito(Remito remito)
    //    {
    //        return remito.Imprimir();
    //    }
    //}

    #endregion

    #region Bad

    public class Impresora
    {
        public string Imprimir(Documento documento)
        {
            return documento.Imprimir();
        }
    }

    #endregion
}
