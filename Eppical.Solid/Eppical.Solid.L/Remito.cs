using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eppical.Solid.L
{

    #region Good
    //public class Remito
    //{
    //    public int Numero { get; set; }
    //    public DateTime Fecha { get; set; }

    //    public int CantBultos { get; set; }
    //    public Remito(int numero, DateTime fecha, int cantBultos)
    //    {
    //        this.Numero = numero;
    //        this.Fecha = fecha;
    //        this.CantBultos = cantBultos;
    //    }

    //    public string Imprimir()
    //    {
    //        return $"Imprimiendo {this.Descripcion()}";
    //    }

    //    public string Descripcion()
    //    {
    //        return $"Remito nro {this.Numero} con {this.CantBultos} bultos";
    //    }

    //}
    #endregion

    #region Bad

    public class Remito : Documento
    {
        public int CantBultos { get; set; }
        public Remito(int numero, DateTime fecha, int cantBultos) : base(numero, fecha)
        {
            CantBultos = cantBultos;
        }

        public override string Descripcion()
        {
            return $"Remito nro {this.Numero} con {this.CantBultos} bultos";
        }

    }

    #endregion

}
