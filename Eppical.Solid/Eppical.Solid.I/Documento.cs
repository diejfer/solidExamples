namespace Eppical.Solid.I
{
    #region Good

    public abstract class Documento : IImprimible
    {
        public DateTime Fecha { get; set; }
        public int Numero { get; set; }

        public Documento(int numero, DateTime fecha)
        {
            this.Numero = numero;
            this.Fecha = fecha;
        }

        public abstract string Imprimir();

    }

    #endregion

    #region Bad
    //public abstract class Documento
    //{
    //    public DateTime Fecha { get; set; }
    //    public int Numero { get; set; }
    //    public Documento(int numero, DateTime fecha)
    //    {
    //        this.Numero = numero;
    //        this.Fecha = fecha;
    //    }

    //    public abstract string Imprimir();
    //    public abstract string EnviarPorEmail();
    //}

    #endregion

}