using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eppical.Solid.S.Test
{
    public class ItemTest
    {
        [Fact]
        public void SubtotalItem()
        {
            var producto = new Producto("descrip producto", 100);

            var item = new Item(producto, 3);

            Assert.Equal(300, item.Subtotal());
        }
    }
}
