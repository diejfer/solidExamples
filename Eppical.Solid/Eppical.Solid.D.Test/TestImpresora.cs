namespace Eppical.Solid.D.Test
{

    public class TestImpresora
    {
        [Fact]
        public void TestFactura()
        {
            Factura factura = new Factura(123, DateTime.Now, 1000);
            Impresora impresora = new Impresora();

            string respEsperada = "Factura 123 impresa correctamente";
            string respReal = impresora.Imprimir(factura);

            Assert.Equal(respEsperada, respReal);
        }

        [Fact]
        public void TestNotaCredito()
        {
            NotaCredito notaCredito = new NotaCredito(456, DateTime.Now, 2000);
            Impresora impresora = new Impresora();

            string respEsperada = "Nota de Crédito 456 impresa correctamente";
            string respReal = impresora.Imprimir(notaCredito);

            Assert.Equal(respEsperada, respReal);
        }

        [Fact]
        public void TestMunicipal()
        {
            Municipal municipal = new Municipal(3000, "123456789");
            Impresora impresora = new Impresora();

            string respEsperada = "Impuesto Municipal Partida 123456789 impreso correctamente";
            string respReal = impresora.Imprimir(municipal);

            Assert.Equal(respEsperada, respReal);
        }

        [Fact]
        public void TestFacturaLuz()
        {
            FacturaLuz facturaLuz = new FacturaLuz(4000, "987654321");
            Impresora impresora = new Impresora();

            string respEsperada = "Factura de Luz Código 987654321 impresa correctamente";
            string respReal = impresora.Imprimir(facturaLuz);

            Assert.Equal(respEsperada, respReal);

        }

        [Fact]
        public void TestReciboSueldo()
        {
            ReciboSueldo reciboSueldo = new ReciboSueldo(123, 5000);
            Impresora impresora = new Impresora();

            string respEsperada = "Recibo de Sueldo Legajo 123 impreso correctamente";
            string respReal = impresora.Imprimir(reciboSueldo);

            Assert.Equal(respEsperada, respReal);
        }

        [Fact]
        public void TestRemito()
        {
            Remito remito = new Remito(456, DateTime.Now, 6000);
            Impresora impresora = new Impresora();

            string respEsperada = "Remito Número 456 impreso correctamente";
            string respReal = impresora.Imprimir(remito);

            Assert.Equal(respEsperada, respReal);
        }
    }

 
}