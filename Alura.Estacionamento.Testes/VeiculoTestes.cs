using Alura.Estacionamento.Modelos;

namespace Alura.Estacionamento.Testes
{
    public class VeiculoTestes
    {
        [Fact]
        public void TestaAcelerar()
        {
            //Arrange - Inicializa��o das vari�veis
            Veiculo veiculo = new Veiculo();
            //Act - Invoca��o do m�todo que ser� testado
            veiculo.Acelerar(10);
            //Assert - Verifica��o do resultado
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