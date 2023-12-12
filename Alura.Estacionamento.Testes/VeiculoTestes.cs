using Alura.Estacionamento.Modelos;

namespace Alura.Estacionamento.Testes
{
    public class VeiculoTestes
    {
        [Fact (DisplayName ="Teste n�1")]
        public void TestaAcelerar()
        {
            //Arrange - Inicializa��o das vari�veis
            Veiculo veiculo = new Veiculo();
            //Act - Invoca��o do m�todo que ser� testado
            veiculo.Acelerar(10);
            //Assert - Verifica��o do resultado
            Assert.Equal(100, veiculo.VelocidadeAtual);
        }
        [Fact(DisplayName = "Teste n�2")]
        public void TestaFreiar()
        {
            //Arrange
            Veiculo veiculo = new Veiculo();
            //Act
            veiculo.Frear(8);
            //Assert
            Assert.Equal(-120, veiculo.VelocidadeAtual);
        }
        [Fact(Skip = "Teste ainda n�o implementado. Ignorar")]
        public void ValidaNomeProprietario()
        {

        }
    }
}