namespace Eppical.Solid.S.Test
{
    public class FacturaTest
    {
        [Fact]
        public void TotalFactura()
        {
            var cliente = new Cliente("Diego", "Fernandez");
            var factura = new Factura(1,cliente);

            var prod1 = new Producto("manteca", 100);
            var prod2 = new Producto("Leche UAT", 85);
            var prod3 = new Producto("Queso", 450);

            factura.Items = new List<Item>();
            factura.Items.Add(new Item(prod1, 3));
            factura.Items.Add(new Item(prod2, 6));
            factura.Items.Add(new Item(prod3, 1));

            Assert.Equal(1260, factura.Total());
        }

       
    }
}