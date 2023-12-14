using CSharp.Models;

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Pessoa pessoa1 = new Pessoa();

pessoa1.Nome = "Pastel";
pessoa1.Idade = 25;
pessoa1.RepresentanteLegal = "Tio Zé";
pessoa1.Altura = 1.90;
pessoa1.Dinheiro = 25.95M;
DateTime dataAtual = DateTime.Now;
pessoa1.DataAtual = dataAtual;
DateTime dataSemanaQueVem = DateTime.Now.AddDays(7);
pessoa1.DataSemanaQueVem = dataSemanaQueVem;
pessoa1.Apresentar();

void Inputs(){
    Pessoa pessoa2 = new Pessoa();
    Console.WriteLine("Digite o nome: ");
    pessoa2.Nome = Console.ReadLine();
    Console.WriteLine("Digite a idade: ");
    pessoa2.Idade = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o representante legal: ");
    pessoa2.RepresentanteLegal = Console.ReadLine();
    Console.WriteLine("Digite a altura: ");
    pessoa2.Altura = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Digite o dinheiro: ");
    pessoa2.Dinheiro = Convert.ToDecimal(Console.ReadLine());
    DateTime dataAtual = DateTime.Now;
    pessoa2.DataAtual = dataAtual;
    DateTime dataSemanaQueVem = DateTime.Now.AddDays(7);
    pessoa2.DataSemanaQueVem = dataSemanaQueVem;
    pessoa2.Apresentar();
}


string opcao;
bool saindo = true;

while(saindo){
    Console.WriteLine("Digite a sua opção");
    Console.WriteLine("1 - Cadastrar");
    Console.WriteLine("2 - Apagar");
    Console.WriteLine("3 - Sair");

    opcao = Console.ReadLine();
    
    switch(opcao)
    {
        case "1": Console.WriteLine("Fazendo"); break;
        case "2": Console.WriteLine("Fazendo o 2"); break;
        // case "3": Console.WriteLine("Fazendo o 3"); Environment.Exit(0); break;
        case "3": Console.WriteLine("Fazendo o 3"); saindo=false; break;
        default: Console.WriteLine("Opção Inválida"); break;
    }
    Console.Clear();
}

Console.WriteLine("O programa acabou");