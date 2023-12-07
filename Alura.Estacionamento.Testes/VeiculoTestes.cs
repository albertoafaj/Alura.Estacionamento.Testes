using Alura.Estacionamento.Modelos;

namespace Alura.Estacionamento.Testes
{
    public class VeiculoTestes
    {
        [Fact]
        public void TestaAcelerar()
        {
            //Arrange - Inicialização das variáveis
            Veiculo veiculo = new Veiculo();
            //Act - Invocação do método que será testado
            veiculo.Acelerar(10);
            //Assert - Verificação do resultado
            Assert.Equal(100, veiculo.VelocidadeAtual);
        }
        [Fact]
        public void TestaFreiar()
        {
            //Arrange
            Veiculo veiculo = new Veiculo();
            //Act
            veiculo.Frear(8);
            //Assert
            Assert.Equal(-120, veiculo.VelocidadeAtual);
        }
    }
}