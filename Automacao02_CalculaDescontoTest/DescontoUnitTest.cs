using Automacao02_CalculaDesconto;

namespace Automacao02_CalculaDescontoTest
{
    [TestClass]
    public sealed class DescontoUnitTest
    {
        private Desconto desconto;

        [TestInitialize]
        public void setup()
        {
            desconto = new Desconto();
        }

        [TestMethod]
        [DataRow(200, false)]
        [DataRow(420, true)]
        [DataRow(1200, true)]
        [DataRow(3725, true)]
        [DataRow(5800, true)]
        [DataRow(350, true)]
        [DataRow(1000, true)]
        [DataRow(3000, true)]
        [DataRow(5000, true)]
        public void valor_DeveVerificarDesconto(float valor, bool esperado)
        {
            // Arrange - Prepara tudo

            // Act - Executa o artefato
            bool obtido = desconto.recebeDesconto(valor);

            // Assert - Compara resultados e decide se passou
            Assert.AreEqual(esperado, obtido);
            //Assert.IsTrue(obtido==esperado);
        }

        [TestMethod]
        [DataRow(200, 0)]
        [DataRow(5632.45f, 0.03f)]
        public void valor_DeveRetornarPercDesconto(float valor, float esperado)
        {
            // - Act Executa o artefato a ser testado
            float obtido = desconto.percentualDesconto(valor);

            // Assert - Comparando resultados e decidindo se aprovado
            Assert.AreEqual(esperado, obtido);
        }
    }
}
