using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp.Models
{
    public sealed class Aluno : Pessoa {
        public Aluno (string nome, string representanteLegal) : base(nome){
            _representanteLegal = representanteLegal;
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