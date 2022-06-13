namespace Eppical.Solid.L
{
    public class Documento
    {
        protected string _sigla;
        public DateTime Fecha { get; set; }
        public int Numero { get; set; }

        public Documento(int numero, DateTime fecha)
        {
            this.Numero = numero;
            this.Fecha = fecha;
        }

        public string Imprimir()
        {
            return $"Imprimiendo {this.Descripcion()}";
        }

        public virtual string Descripcion()
        {
            return $"{this._sigla} nro {this.Numero}";
        }
         
    }
}