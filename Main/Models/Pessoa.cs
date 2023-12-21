using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp.Models
{
    public abstract class Pessoa
    {
        // criando um constructor
        public Pessoa(string nome, string sobrenome, int idade, double altura, DateTime dataAtual, DateTime dataSemanaQueVem){
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
            Altura = altura;
            DataAtual = dataAtual;
            DataSemanaQueVem = dataSemanaQueVem;
        }

        // public Pessoa(string nome){
        //     Nome = nome;
        // }

        public Pessoa(){

        }
        
        // protegendo propriedades
        public string  _nome;
        public string Nome {
            // get{
            //     return _nome.ToUpper();
            // };
            get => _nome.ToUpper();
            
            set{
                if (value == ""){
                    throw new ArgumentException("Nome não pode ser vazio");
                }
                _nome = value;
            }
        }
        public string _sobrenome;
        public string Sobrenome {get;set;}

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int _idade;
        public int Idade {
            get => _idade;
            set{
                if (value < 0){
                    throw new ArgumentException("Idade não pode ser negativa");
                }

                _idade = value;
            }
        }

        public double Altura {get;set;}
        public DateTime DataAtual {get;set;}
        public DateTime DataSemanaQueVem {get;set;}


        public virtual void Apresentar() {
            Console.WriteLine($"Meu nome é {Nome}" +
            $"e possuo {Idade} anos. \n" +
            $"\nMinha altura é {Altura.ToString("0.00")}" +
            $"\nA data atual é {DataAtual.ToString("dd/MM/yyyy")} e daqui ha uma semana será {DataSemanaQueVem.ToString("dd/MM/yyyy")}");
        }
    }
}