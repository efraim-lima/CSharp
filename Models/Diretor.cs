using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp.Models
{
    public class Diretor : Pessoa
    {
        public decimal Dinheiro {get;set;}

        public override void Apresentar(){
            Console.WriteLine($"Meu nome é {Nome}" +
            $"e possuo {Idade} anos." +
            $"\nAgora, minha altura é {Altura.ToString("0.00")} e estou com R${Dinheiro} no bolso." +
            $"\nA data atual é {DataAtual.ToString("dd/MM/yyyy")} e daqui ha uma semana será {DataSemanaQueVem.ToString("dd/MM/yyyy")}");
        }
    }
}