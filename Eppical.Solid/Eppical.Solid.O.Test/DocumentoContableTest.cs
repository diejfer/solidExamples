namespace Eppical.Solid.O.Test
{
    public class DocumentoContableTest
    {
        #region Good

        [Fact]
        public void TestDescripcionFactura()
        {
            // Arrange (Preparar) - Act (Actuar)
            Factura factura = new Factura(123);

            // Assert (Afirmar)
            string descripcionEsperada = "FC-123";
            string descripcionReal = factura.Descripcion();
            Assert.Equal(descripcionEsperada, descripcionReal);
        }

        [Fact]
        public void TestDescripcionNotaCredito()
        {
            // Arrange (Preparar) - Act (Actuar)
            NotaCredito notaCredito = new NotaCredito(456);

            // Assert (Afirmar)
            string descripcionEsperada = "NC-456";
            string descripcionReal = notaCredito.Descripcion();
            Assert.Equal(descripcionEsperada, descripcionReal);
        }

        [Fact]
        public void TestDescripcionNotaDebito()
        {
            // Arrange (Preparar) - Act (Actuar)
            NotaDebito notaDebito = new NotaDebito(789);

            // Assert (Afirmar)
            string descripcionEsperada = "ND-789";
            string descripcionReal = notaDebito.Descripcion();
            Assert.Equal(descripcionEsperada, descripcionReal);
        }
        #endregion

        #region Bad
        //[Fact]
        //public void TestDescripcionFactura()
        //{
        //    // Arrange (Preparar) - Act (Actuar)
        //    DocumentoContable documentoContable = new DocumentoContable(TipoDocumentoContable.Factura, 123);

        //    // Assert (Afirmar)
        //    string descripcionEsperada = "FC-123";
        //    string descripcionReal = documentoContable.Descripcion();
        //    Assert.Equal(descripcionEsperada, descripcionReal);
        //}
        //[Fact]
        //public void TestDescripcionNotaCredito()
        //{
        //    // Arrange (Preparar) - Act (Actuar)
        //    DocumentoContable documentoContable = new DocumentoContable(TipoDocumentoContable.NotaCredito, 456);

        //    // Assert (Afirmar)
        //    string descripcionEsperada = "NC-456";
        //    string descripcionReal = documentoContable.Descripcion();
        //    Assert.Equal(descripcionEsperada, descripcionReal);
        //}

        //[Fact]
        //public void TestDescripcionNotaDebito()
        //{
        //    // Arrange (Preparar) - Act (Actuar)
        //    DocumentoContable documentoContable = new DocumentoContable(TipoDocumentoContable.NotaDebito, 789);

        //    // Assert (Afirmar)
        //    string descripcionEsperada = "ND-789";
        //    string descripcionReal = documentoContable.Descripcion();
        //    Assert.Equal(descripcionEsperada, descripcionReal);
        //}
        #endregion
    }
}