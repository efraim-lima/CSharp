using CSharp.Models;

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

Curso novoCurso = new Curso();
novoCurso.Alunos = new List<Aluno>();

Console.WriteLine("Por favor, digite o nome do curso: ");
novoCurso.Nome = Console.ReadLine();

// Aluno pessoa1 = new Aluno(
//     nome: "Efraim",
//     sobrenome: "de Almeida Lima",
//     idade: 80,
//     altura: 1.74,
//     representanteLegal: "Pastel",
//     dataAtual: DateTime.Now,
//     dataSemanaQueVem: DateTime.Now.AddDays(7)
//     );
// novoCurso.Adicionar(pessoa1);
/*

pessoa1.Nome = "Pastel";
pessoa1.Sobrenome = "de Frango";
pessoa1.Idade = 25;
pessoa1.RepresentanteLegal = "Tio Zé";
pessoa1.Altura = 1.90;
pessoa1.Dinheiro = 25.95M;
DateTime dataAtual = DateTime.Now;
pessoa1.DataAtual = dataAtual;
DateTime dataSemanaQueVem = DateTime.Now.AddDays(7);
pessoa1.DataSemanaQueVem = dataSemanaQueVem;
pessoa1.Apresentar();
*/
void Inputs(){
/*static List<string> Inputs(){
    string[] dadosPessoa2 = {};
    List<string> Lista = dadosPessoa2.ToList();*/
    Aluno pessoa2 = new Aluno();

    Console.WriteLine("Digite o nome: ");
    pessoa2.Nome = Console.ReadLine();
    string nome = Convert.ToString(pessoa2.Nome);
    // Lista.Add(nome);
    Console.WriteLine("Digite o sobrenome: ");
    pessoa2.Sobrenome = Console.ReadLine();
    string sobrenome = Convert.ToString(pessoa2.Sobrenome);
    // Lista.Add(sobrenome);
    Console.WriteLine("Digite a idade: ");
    pessoa2.Idade = Convert.ToInt32(Console.ReadLine());
    string idade = Convert.ToString(pessoa2.Idade);
    // Lista.Add(idade);
    Console.WriteLine("Digite o representante legal: ");
    pessoa2.RepresentanteLegal = Console.ReadLine();
    string representante = Convert.ToString(pessoa2.RepresentanteLegal);
    // Lista.Add(representante);
    Console.WriteLine("Digite a altura: ");
    pessoa2.Altura = Convert.ToDouble(Console.ReadLine());
    string altura = Convert.ToString(pessoa2.Altura);
    // Lista.Add(altura);
    DateTime dataAtual = DateTime.Now;
    pessoa2.DataAtual = dataAtual;
    string dataAtual2 = Convert.ToString(pessoa2.DataAtual);
    // Lista.Add(dataAtual2);
    DateTime dataSemanaQueVem = DateTime.Now.AddDays(7);
    pessoa2.DataSemanaQueVem = dataSemanaQueVem;
    string semanaQueVem = Convert.ToString(pessoa2.DataSemanaQueVem);
    // Lista.Add(semanaQueVem);
    pessoa2.Apresentar();
    novoCurso.Adicionar(pessoa2);
    // return Lista;
}

string opcao;
bool saindo = true;
List<string> Lista = new List<string>();

while(saindo==true){
    Console.WriteLine("Digite a sua opção");
    Console.WriteLine("1 - Cadastrar");
    Console.WriteLine("2 - Listar dados");
    Console.WriteLine("3 - Sair");

    opcao = Console.ReadLine();
    // if (opcao != "2" && opcao != "3") Lista = Inputs();
    
    switch(opcao)
    {
        // case "1": Console.WriteLine("Fazendo"); Lista = Inputs(); break;
        // case "2": Console.WriteLine("Fazendo o 2"); Listar(Lista); break;
        case "1": Console.WriteLine("Fazendo"); Inputs(); break;
        case "2": Console.WriteLine("Fazendo o 2"); novoCurso.Listar(); break;
        case "3": Console.WriteLine("Fazendo o 3"); saindo=false; break;
        default: Console.WriteLine("Opção Inválida"); break;
    }
    Console.WriteLine("Digite qualquer tecla para sair. ");
    Console.ReadLine();
    Console.Clear();
}

Console.WriteLine("O programa acabou");

void Listar(List<string> Lista = null){
    string[] dados = {
        "nome: Zé", 
        "idade: 25", 
        "representante: Joao", 
        "altura: 1.70",
        "data: 14/12/2023", 
        "data futura: 21/12/2023"
    };

    if (dados.Length < Lista.Count || dados.Length > Lista.Count){
        Array.Resize(ref dados, Lista.Count);
    }

    for (int i = 0; i < dados.Length; i++){
        Console.WriteLine(dados[i]);
    };

    // Console.WriteLine("Usando foreach");
    // int contador = 0;
    // foreach(string item in dados){
    //     Console.WriteLine(item);
    //     contador++;
    // };
}