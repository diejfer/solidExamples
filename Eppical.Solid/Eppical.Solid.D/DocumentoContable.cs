namespace Eppical.Solid.D
{
    #region Good

    //public abstract class DocumentoContable : IImprimible
    //{
    //    protected string _sigla;
    //    public DateTime Fecha { get; set; }
    //    public double Importe { get; set; }
    //    public int Numero { get; set; }

    //    public DocumentoContable(int numero, DateTime fecha, double importe)
    //    {
    //        this.Numero = numero;
    //        this.Fecha = fecha;
    //        this.Importe = importe;
    //    }

    //    public abstract double Total();

    //    public abstract string Imprimir();
    //}

    #endregion

    #region Bad
    public abstract class DocumentoContable
    {
        protected string _sigla;
        public DateTime Fecha { get; set; }
        public double Importe { get; set; }
        public int Numero { get; set; }

        public DocumentoContable(int numero, DateTime fecha, double importe)
        {
            this.Numero = numero;
            this.Fecha = fecha;
            this.Importe = importe;
        }

        public abstract double Total();
    }

    #endregion
}