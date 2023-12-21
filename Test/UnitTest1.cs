using Main.Models;
namespace Test;

public class Test
{
    private Professor _professor;

    public Teste() {
        _professor = new Professor();
        return $"Meu nome é {nomeProfessor}" +
            $"e possuo {idadeProfessor} anos. \n" +
            $"\nMinha altura é {alturaProfessor.ToString("0.00")}" +
            $"\nA data atual é {dataAtual.ToString("dd/MM/yyyy")} e daqui ha uma semana será {dataSemanaQueVem.ToString("dd/MM/yyyy")}";
    }

    [Fact]
    public void DeveRetornarTextoComNomeIdadeAlturaDinheiroDataAtualDataSemanaQueVem()
    {
        // Arrange
        string nomeProfessor = "Efraim";
        int idadeProfessor = 80;
        double alturaProfessor = 1.74;
        decimal dinheiroProfessor = 30000;
        DateTime dataAtual = DateTime.Now;
        DateTime dataSemanaQueVem = DateTime.Now.AddDays(7);

        // Act
        string saida = _professor.Apresentar(
            nomeProfessor,
            idadeProfessor,
            alturaProfessor,
            dinheiroProfessor,
            dataAtual,
            dataSemanaQueVem
            );

        // Assert
        Assert.Equal($"Meu nome é {nomeProfessor}" +
            $"e possuo {idadeProfessor} anos. \n" +
            $"\nMinha altura é {alturaProfessor.ToString("0.00")}" +
            $"\nA data atual é {dataAtual.ToString("dd/MM/yyyy")} e daqui ha uma semana será {dataSemanaQueVem.ToString("dd/MM/yyyy")}", saida);
    }
}