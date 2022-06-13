using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eppical.Solid.D
{
    public class Municipal : Impuesto
    {
        public string Partida { get; set; }
        public Municipal(double importe, string partida) : base(importe)
        {
            this.Partida = partida;
        }

        public override string Imprimir()
        {
            return $"Impuesto Municipal Partida {this.Partida} impreso correctamente";
        }
    }
}
