using Moq;

namespace Eppical.Solid.S.Test
{
    public class FacturaTest
    {
        #region Good
        /// <summary>
        /// Testeamos la logica de calculo del total de factura y tambien el calculo del subtotal del item
        /// </summary>
        [Fact]
        public void TotalFactura()
        {
            // Arrange (Preparar)
            var cliente = new Cliente("Diego", "Fernandez");
            var factura = new Factura(1, cliente);

            var prod1 = new Producto("Manteca", 100);
            var prod2 = new Producto("Leche UAT", 85);
            var prod3 = new Producto("Queso", 450);

            factura.Items = new List<IItem>();
            factura.Items.Add(new Item(prod1, 3));
            factura.Items.Add(new Item(prod2, 6));
            factura.Items.Add(new Item(prod3, 1));

            // Act (Actuar
            var totalEsperado = 1260;
            var totalReal = factura.Total();

            // Assert (Afirmar)
            Assert.Equal(totalEsperado, totalReal);
        }

        /// <summary>
        /// Testeamos SOLAMENTE la logica del total de la factura usando mocks para los subtotal del item
        /// </summary>
        [Fact]
        public void TotalFacturaUnitario()
        {
            var cliente = new Cliente("Diego", "Fernandez");
            var factura = new Factura(1, cliente);

            var mockItem1 = new Mock<IItem>();
            mockItem1.Setup(x => x.Subtotal()).Returns(100);

            var mockItem2 = new Mock<IItem>();
            mockItem2.Setup(x => x.Subtotal()).Returns(150);

            var mockItem3 = new Mock<IItem>();
            mockItem3.Setup(x => x.Subtotal()).Returns(175);

            factura.Items = new List<IItem>();
            factura.Items.Add(mockItem1.Object);
            factura.Items.Add(mockItem2.Object);
            factura.Items.Add(mockItem3.Object);

            Assert.Equal(425, factura.Total());
        }

        #endregion

        #region Bad
        //[Fact]
        //public void TotalFactura()
        //{
        //    // Arrange (Preparar)
        //    string nombre = "Victor";
        //    string apellido = "Passador";
        //    Factura factura = new Factura(1, nombre, apellido);
        //    Producto prod1 = new Producto("Manteca", 100);
        //    Producto prod2 = new Producto("Leche UAT", 85);
        //    Producto prod3 = new Producto("Queso", 450);

        //    // Act (Actuar)
        //    factura.Items.Add(new Item(prod1, 3));
        //    factura.Items.Add(new Item(prod2, 6));
        //    factura.Items.Add(new Item(prod3, 1));

        //    // Assert (Afirmar)
        //    double totalEsperado = 1260; // (3 * 100) + (6 * 85) + (1 * 450);
        //    Assert.Equal(totalEsperado, factura.Total());
        //}
        #endregion
    }
}