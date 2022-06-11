using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eppical.Solid.S
{
    public class Factura
    {
        #region Good
        public int Numero { get; set; }
        public Cliente Cliente { get; private set; }
        public DateTime Fecha { get; set; }
        
        public Factura(int numero, Cliente cliente)
        {
            this.Numero = numero;
            this.Cliente = cliente;
            this.Fecha = DateTime.UtcNow;
        }


        public List<IItem> Items { get; set; }

        public double Total()
        {
            double total = 0;
            foreach (var item in this.Items)
            {
                total += item.Subtotal();
            }

            return total;
        }
        #endregion

        #region Bad

        //public int Numero { get; set; }
        //public string Nombre { get; set; }
        //public string Apellido { get; set; }
        //public DateTime Fecha { get; set; }
        //public List<Item> Items { get; set; }

        //public Factura(int numero, string nombre, string apellido)
        //{
        //    this.Numero = numero;
        //    this.Nombre = nombre;
        //    this.Apellido = apellido;
        //    this.Fecha = DateTime.UtcNow;
        //    this.Items = new List<Item>();
        //}

        //public double Total()
        //{
        //    double total = 0;

        //    foreach (var item in Items)
        //    {
        //        total += item.Cantidad * item.Producto.Precio;
        //    }

        //    return total;
        //}


        #endregion


    }
}
