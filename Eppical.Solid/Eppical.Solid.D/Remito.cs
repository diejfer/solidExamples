using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eppical.Solid.D
{
    public  class Remito : IImprimible
    {
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public int CantBultos { get; set; }

        public Remito(int numero, DateTime fecha, int cantBultos)
        {
            this.Numero = numero;
            this.Fecha = fecha;
            this.CantBultos = cantBultos;
        }

        public string Imprimir()
        {
            return $"Remito Número {this.Numero} impreso correctamente";
        }
    }
}
