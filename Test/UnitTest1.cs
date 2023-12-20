using Main.Models;
namespace Test;

public class Test
{
    private Professor _professor;

    public Teste() {
        Professor = new Professor();
    }

    public Professor Professor { get => _professor; set => _professor = value; }

    [Fact]
    public void DeveRetornarTextoComNomeIdadeAlturaDinheiroDataAtualDataSemanaQueVem()
    {
        // Arrange
        string Nome = "Pedro";
        int Idade = 25;
        double Altura = 1.80m;
        decimal Dinheiro = 1000m;
        DateTime DataAtual = DateTime.Now;
        DateTime DataSemanaQueVem = DateTime.Now.AddDays(7);
        
        // Act
        string saida = new _professor( 
            nome: "Efraim",
            sobrenome: "de Almeida Lima",
            idade: 80,
            altura: 1.74,
            dinheiro: 30000,
            dataAtual: DateTime.Now,
            dataSemanaQueVem: DateTime.Now.AddDays(7)
            );

        // Assert
        Assert.Equal($"Meu nome é {Nome}" +
            $"e possuo {Idade} anos. \n" +
            $"\nMinha altura é {Altura.ToString("0.00")}" +
            $"\nA data atual é {DataAtual.ToString("dd/MM/yyyy")} e daqui ha uma semana será {DataSemanaQueVem.ToString("dd/MM/yyyy")}");
    }
}