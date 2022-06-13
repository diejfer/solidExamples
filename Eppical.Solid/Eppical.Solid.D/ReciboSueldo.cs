using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eppical.Solid.D
{
    public class ReciboSueldo : IImprimible
    {
        public double Total { get; set; }
        public int Legajo { get; set; }

        public ReciboSueldo(int legajo, double total)
        {
            this.Legajo = legajo;
            this.Total = total;
        }

        public string Imprimir()
        {
            return $"Recibo de Sueldo Legajo {this.Legajo} impreso correctamente";
        }
    }
}
