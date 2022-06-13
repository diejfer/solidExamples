namespace Eppical.Solid.L.Test
{
    public class DocumentoTest
    {
        #region Good
        [Fact]
        public void TestImprimirFactura()
        {
            // Arrange
            Factura factura = new Factura(123, DateTime.Today);
            Impresora impresora = new Impresora();

            // Act
            string resultadoEsperado = "Imprimiendo FC nro 123";
            string resultadoReal = impresora.Imprimir(factura);

            // Assert
            Assert.Equal(resultadoEsperado, resultadoReal);
        }

        [Fact]
        public void TestImprimirNotaCredito()
        {
            // Arrange
            NotaCredito notaCredito = new NotaCredito(456, DateTime.Today);
            Impresora impresora = new Impresora();

            // Act
            string resultadoEsperado = "Imprimiendo NC nro 456";
            string resultadoReal = impresora.Imprimir(notaCredito);

            // Assert
            Assert.Equal(resultadoEsperado, resultadoReal);
        }

        [Fact]
        public void TestImprimirRemito()
        {
            // Arrange
            Remito remito = new Remito(789, DateTime.Today, 100);
            Impresora impresora = new Impresora();

            // Act
            string resultadoEsperado = "Imprimiendo Remito nro 789 con 100 bultos";
            string resultadoReal = impresora.ImprimirRemito(remito);

            // Assert
            Assert.Equal(resultadoEsperado, resultadoReal);
        }

        #endregion

        #region Bad
        //[Fact]
        //public void TestImprimirFactura()
        //{
        //    // Arrange
        //    Factura factura = new Factura(123, DateTime.Today);
        //    Impresora impresora = new Impresora();

        //    // Act
        //    string resultadoEsperado = "Imprimiendo FC nro 123";
        //    string resultadoReal = impresora.Imprimir(factura);

        //    // Assert
        //    Assert.Equal(resultadoEsperado, resultadoReal);
        //}

        //[Fact]
        //public void TestImprimirNotaCredito()
        //{
        //    // Arrange
        //    NotaCredito notaCredito = new NotaCredito(456, DateTime.Today);
        //    Impresora impresora = new Impresora();

        //    // Act
        //    string resultadoEsperado = "Imprimiendo NC nro 456";
        //    string resultadoReal = impresora.Imprimir(notaCredito);

        //    // Assert
        //    Assert.Equal(resultadoEsperado, resultadoReal);
        //}

        //[Fact]
        //public void TestImprimirRemito()
        //{
        //    // Arrange
        //    Remito remito = new Remito(789, DateTime.Today, 100);
        //    Impresora impresora = new Impresora();

        //    // Act
        //    string resultadoEsperado = "Imprimiendo Remito nro 789 con 100 bultos";
        //    string resultadoReal = impresora.Imprimir(remito);

        //    // Assert
        //    Assert.Equal(resultadoEsperado, resultadoReal);
        //}

        #endregion
    }
}