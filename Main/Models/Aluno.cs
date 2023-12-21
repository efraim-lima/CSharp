using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CSharp.Interfaces;

namespace CSharp.Models
{
    public sealed class Aluno : Pessoa {
        public Aluno (string nome, string sobrenome, int idade, double altura, DateTime dataAtual, DateTime dataSemanaQueVem) : base(nome, sobrenome, idade, altura, dataAtual, dataSemanaQueVem){
        }
        public Aluno (string nome, string sobrenome, int idade, string representanteLegal, double altura, DateTime dataAtual, DateTime dataSemanaQueVem) {
        }
        public Aluno(){

        }

        public string _representanteLegal;
        public string RepresentanteLegal {
            get => _representanteLegal.ToUpper();
            set{
                if (value == ""){
                    throw new ArgumentException("Nome não pode ser vazio");
                }
                
                _representanteLegal = value;
            }
        }

        public override void Apresentar()
        {
            Console.WriteLine($"Meu nome é {Nome}" +
            $"e possuo {Idade} anos. \nMeu representante é: {RepresentanteLegal}" +
            $"\nAgora, minha altura é {Altura.ToString("0.00")}" +
            $"\nA data atual é {DataAtual.ToString("dd/MM/yyyy")} e daqui ha uma semana será {DataSemanaQueVem.ToString("dd/MM/yyyy")}");
        }
    }
}