using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharp.Interfaces;

namespace CSharp.Models
{
    public class Diretor : Pessoa, Acoes
    {
        public decimal Dinheiro {get;set;}
        public bool Cadastro { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Matricula { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool Acesso { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Apresentar(){
            Console.WriteLine($"Meu nome é {Nome}" +
            $"e possuo {Idade} anos." +
            $"\nAgora, minha altura é {Altura.ToString("0.00")} e estou com R${Dinheiro} no bolso." +
            $"\nA data atual é {DataAtual.ToString("dd/MM/yyyy")} e daqui ha uma semana será {DataSemanaQueVem.ToString("dd/MM/yyyy")}");
        }
    }
}