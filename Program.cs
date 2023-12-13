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