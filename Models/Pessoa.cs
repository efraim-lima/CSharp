using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp.Models
{
    public class Pessoa
    {
        // criando um constructor
        public Pessoa(string nome, string sobrenome, int idade, decimal dinheiro, double altura, DateTime dataAtual, DateTime dataSemanaQueVem){
            Nome =nome;
            Sobrenome=sobrenome;
            Idade=idade;
            Altura = altura;
            Dinheiro = dinheiro;
            DataAtual = dataAtual;
            DataSemanaQueVem = dataSemanaQueVem;
        }

        public Pessoa(){

        }

        // protegendo propriedades
        private string _nome;
        private string _sobrenome;
        private int _idade;
        private string _representanteLegal;

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

        public string Sobrenome {get;set;}

        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

        public int Idade {
            get => _idade;
            set{
                if (value < 0){
                    throw new ArgumentException("Idade não pode ser negativa");
                }

                _idade = value;
            }
        }

        public string RepresentanteLegal {
            get => _representanteLegal.ToUpper();
            set{
                if (value == ""){
                    throw new ArgumentException("Nome não pode ser vazio");
                }
                
                _representanteLegal = value;
            }
        }

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