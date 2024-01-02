using Alura.Estacionamento.Alura.Estacionamento.Modelos;
using Alura.Estacionamento.Modelos;
using Xunit.Abstractions;

namespace Alura.Estacionamento.Testes
{
    public class VeiculoTestes : IDisposable
    {
        private Veiculo veiculo;
        public ITestOutputHelper SaidaConsoleTeste;
        public VeiculoTestes(ITestOutputHelper _saidaConsoleTeste)
        {
            veiculo = new Veiculo();
            SaidaConsoleTeste = _saidaConsoleTeste;
            SaidaConsoleTeste.WriteLine("Construtor invocado");
        }

        [Fact (DisplayName ="Teste nº1")]
        public void TestaAcelerar()
        {
            //Arrange - Inicialização das variáveis
            //Veiculo veiculo = new Veiculo();
            //Act - Invocação do método que será testado
            veiculo.Acelerar(10);
            //Assert - Verificação do resultado
            Assert.Equal(100, veiculo.VelocidadeAtual);
        }
        [Fact(DisplayName = "Teste nº2")]
        public void TestaFreiar()
        {
            //Arrange
            //Veiculo veiculo = new Veiculo();
            //Act
            veiculo.Frear(8);
            //Assert
            Assert.Equal(-120, veiculo.VelocidadeAtual);
        }
        [Fact(Skip = "Teste ainda não implementado. Ignorar")]
        public void ValidaNomeProprietario()
        {

        }

        [Fact]
        public void DadosVeiculo() 
        {
            //Arrange
            //Veiculo veiculo = new Veiculo();
            veiculo.Proprietario = "Alberto Araujo";
            veiculo.Tipo = TipoVeiculo.Automovel;
            veiculo.Cor = "Verde";
            veiculo.Modelo = "Variant";
            veiculo.Placa = "ASD-9999";

            //Act
            string dados = veiculo.GerarFicha();

            //Assert
            Assert.Contains("Tipo do veículo: Automovel", dados);
        }

        [Fact]
        public void TestaNomeProprietarioComMenosDeTresCaracteres()
        {
            //Arrange
            string nomeProprietario = "Ab";

            //Assert
            Assert.Throws<System.FormatException>(
                //Act
                () => new Veiculo(nomeProprietario)
                ) ;

        }
        [Fact]
        public void TestaMensagemDeExececaoDoQuartoCaracterDaPlaca()
        {
            //Arrange
            string placa = "AAAA9999";

            // Act
            FormatException mensagemErro = Assert.Throws<System.FormatException>(
                
                () => new Veiculo().Placa = placa
                );

            //Assert
            Assert.Equal("O 4° caractere deve ser um hífen", mensagemErro.Message);

        }

        public void Dispose()
        {
            SaidaConsoleTeste.WriteLine("Dispose invocado");
        }
    }
}