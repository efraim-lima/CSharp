using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp.Models
{
    public class Pessoa
    {
        public string Nome {get;set;}
        public int Idade {get;set;}
        public string RepresentanteLegal {get;set;}
        public double Altura {get;set;}
        public decimal Dinheiro {get;set;}
        public DateTime DataAtual {get;set;}
        public DateTime DataSemanaQueVem {get;set;}


        public void Apresentar() {
            Console.WriteLine($"Meu nome é {Nome}" +
            $"e possuo {Idade} anos. \nMeu representante é: {RepresentanteLegal}" +
            $"\nAgora, minha altura é {Altura.ToString("0.00")} e estou com R${Dinheiro} no bolso." +
            $"\nA data atual é {DataAtual.ToString("dd/MM/yyyy")} e daqui ha uma semana será {DataSemanaQueVem.ToString("dd/MM/yyyy")}");
        }
    }
}