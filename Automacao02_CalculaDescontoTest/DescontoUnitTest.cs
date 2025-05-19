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
            // Act - Executa o artefato a ser testado
            bool obtido = desconto.recebeDesconto(valor);

            // Assert - Compara resultados e decide se passou
            Assert.AreEqual(esperado, obtido);
            //Assert.IsTrue(obtido==esperado);
        }

        [TestMethod]
        [DataRow(200, 0)]
        [DataRow(568.35f, 0.005f)]
        [DataRow(2647.50f, 0.01f)]
        [DataRow(4882.21f, 0.02f)]
        [DataRow(8749.64f, 0.03f)]
        public void valor_DeveRetornarPercDesconto(float valor, float esperado)
        {
            //Act - Executa o artefato a ser testado
            float obtido = desconto.percentualDesconto(valor);

            //Assert - Comparando resultados e decidindo se aprovado
            Assert.AreEqual(esperado, obtido);
        }

        [TestMethod]
        [DataRow(200, 0)]
        [DataRow(568.35f, 2.84f)]
        [DataRow(2647.50f, 26.48f)]
        [DataRow(4882.21f, 97.64f)]
        [DataRow(8749.64f, 262.49f)]
        public void valor_DeveRetornarValorDesconto(float valor, float esperado) 
        {
            //Act
            float obtido = desconto.valorDesconto(valor);

            //Assert
            Assert.AreEqual(esperado, obtido, 2);
        }

        [TestMethod]
        [DataRow(200, 200)]
        [DataRow(568.35f, 565.51f)]
        [DataRow(2647.50f, 2621.02f)]
        [DataRow(4882.21f, 4784.57f)]
        [DataRow(8749.64f, 8487.15f)]
        public void valor_deveRetornarLiquidoCompra(float valor, float esperado)
        {
            //Act
            float obtido = desconto.totalCompra(valor);

            //Assert
            Assert.AreEqual(esperado, obtido, 2);
        }
    }
}
