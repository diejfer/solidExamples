namespace Eppical.Solid.O
{
    #region Good

    public abstract class DocumentoContable
    {
        public DateTime Fecha { get; set; }
        public double Importe { get; set; }
        public int Numero { get; set; }

        public DocumentoContable(int numero)
        {
            this.Numero = numero;
        }

        public abstract string Descripcion();
    }

    #endregion

    #region Bad
    //public class DocumentoContable
    //{

    //    public DateTime Fecha { get; set; }
    //    public double Importe { get; set; }
    //    public int Numero { get; set; }
    //    public TipoDocumentoContable Tipo { get; set; }

    //    public DocumentoContable(TipoDocumentoContable tipo, int numero)
    //    {
    //        this.Tipo = tipo;
    //        this.Numero = numero;
    //    }

    //    public string Descripcion()
    //    {
    //        string descripcion = string.Empty;
    //        switch (Tipo)
    //        {
    //            case TipoDocumentoContable.Factura:
    //                descripcion = $"FC-{this.Numero}";
    //                break;
    //            case TipoDocumentoContable.NotaCredito:
    //                descripcion = $"NC-{this.Numero}";
    //                break;
    //            case TipoDocumentoContable.NotaDebito:
    //                descripcion = $"ND-{this.Numero}";
    //                break;
    //            default:
    //                descripcion = "N/D";
    //                break;
    //        }
    //        return descripcion;
    //    }

    //}

    #endregion
}