using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eppical.Solid.S
{
    public class Factura
    {
        public Factura(int numero, Cliente cliente)
        {
            this.Numero = numero;
            this.Cliente = cliente;
            this.Fecha = DateTime.UtcNow;
        }
        public int Numero { get; set; }
        public Cliente Cliente { get; private set; }
        public DateTime Fecha { get; set; }
        
        public List<IItem> Items { get; set; }

        public double Total() {
            double total = 0;
            foreach (var item in this.Items)
            {
                total += item.Subtotal();
            }

            return total;
        }

    }
}
