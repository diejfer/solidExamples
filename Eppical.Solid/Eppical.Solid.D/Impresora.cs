using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eppical.Solid.D
{
    #region Good

    //public class Impresora
    //{
    //    public string Imprimir(IImprimible imprimible)
    //    {
    //        return imprimible.Imprimir();
    //    }

    //}

    #endregion

    #region Bad

    public class Impresora
    {
        public string Imprimir(Factura factura)
        {
            return $"Factura {factura.Numero} impresa correctamente";
        }

        public string Imprimir(NotaCredito notaCredito)
        {
            return $"Nota de Crédito {notaCredito.Numero} impresa correctamente";
        }

        public string Imprimir(Municipal municipal)
        {
            return $"Impuesto Municipal Partida {municipal.Partida} impreso correctamente";
        }

        public string Imprimir(FacturaLuz facturaLuz)
        {
            return $"Factura de Luz Código {facturaLuz.CodigoPago} impresa correctamente";
        }

        public string Imprimir(ReciboSueldo reciboSueldo)
        {
            return $"Recibo de Sueldo Legajo {reciboSueldo.Legajo} impreso correctamente";
        }

        public string Imprimir(Remito remito)
        {
            return $"Remito Número {remito.Numero} impreso correctamente";
        }
    }

    #endregion
}
