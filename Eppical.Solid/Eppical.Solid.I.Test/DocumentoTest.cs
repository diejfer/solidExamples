namespace Eppical.Solid.I.Test
{
    public class DocumentoTest
    {

        #region Good

        //[Fact]
        //public void TestImprimirFactura()
        //{
        //    // Arrange (Preparar)
        //    Factura factura = new Factura(123, DateTime.Now);
        //    factura.CAI = "123456789";

        //    // Act (Actuar)
        //    string mensajeEsperado = "Factura 123 impresa correctamente";
        //    string mensajeReal = factura.Imprimir();

        //    // Assert (Afirmar)
        //    Assert.Equal(mensajeEsperado, mensajeReal);
        //}

        //[Fact]
        //public void TestImprimirFacturaElectronica()
        //{
        //    // Arrange (Preparar)
        //    FacturaElectronica facturaE = new FacturaElectronica(123, DateTime.Now);
        //    facturaE.CAE = "123456789";

        //    // Act (Actuar)
        //    string mensajeEsperado = "Factura electrónica 123 impresa correctamente";
        //    string mensajeReal = facturaE.Imprimir();

        //    // Assert (Afirmar)
        //    Assert.Equal(mensajeEsperado, mensajeReal);
        //}

        //[Fact]
        //public void TestEnviarFacturaElectronica()
        //{
        //    // Arrange (Preparar)
        //    FacturaElectronica facturaE = new FacturaElectronica(456, DateTime.Now);
        //    facturaE.CAE = "987654321";

        //    // Act (Actuar)
        //    string mensajeEsperado = "Factura electrónica 456 enviada correctamente";
        //    string mensajeReal = facturaE.EnviarPorEmail();

        //    // Assert (Afirmar)
        //    Assert.Equal(mensajeEsperado, mensajeReal);
        //}

        #endregion

        #region Bad

        [Fact]
        public void TestImprimirFactura()
        {
            // Arrange (Preparar)
            Factura factura = new Factura(123, DateTime.Now);
            factura.CAI = "123456789";

            // Act (Actuar)
            string mensajeEsperado = "Factura 123 impresa correctamente";
            string mensajeReal = factura.Imprimir();

            // Assert (Afirmar)
            Assert.Equal(mensajeEsperado, mensajeReal);
        }

        [Fact]
        public void TestEnviarFactura()
        {
            // Arrange (Preparar)
            Factura factura = new Factura(456, DateTime.Now);
            factura.CAI = "987654321";

            // Act (Actuar)
            string mensajeEsperado = "Factura 456 enviada correctamente";
            string mensajeReal = factura.EnviarPorEmail();

            // Assert (Afirmar)
            Assert.Equal(mensajeEsperado, mensajeReal);
        }

        [Fact]
        public void TestImprimirFacturaElectronica()
        {
            // Arrange (Preparar)
            FacturaElectronica facturaE = new FacturaElectronica(123, DateTime.Now);
            facturaE.CAE = "123456789";

            // Act (Actuar)
            string mensajeEsperado = "Factura electrónica 123 impresa correctamente";
            string mensajeReal = facturaE.Imprimir();

            // Assert (Afirmar)
            Assert.Equal(mensajeEsperado, mensajeReal);
        }

        [Fact]
        public void TestEnviarFacturaElectronica()
        {
            // Arrange (Preparar)
            FacturaElectronica facturaE = new FacturaElectronica(456, DateTime.Now);
            facturaE.CAE = "987654321";

            // Act (Actuar)
            string mensajeEsperado = "Factura electrónica 456 enviada correctamente";
            string mensajeReal = facturaE.EnviarPorEmail();

            // Assert (Afirmar)
            Assert.Equal(mensajeEsperado, mensajeReal);
        }

        #endregion

    }
}