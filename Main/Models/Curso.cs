using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSharp.Models
{
    public class Curso
    {   
        private string _nome;
        public string Nome {
            get => _nome.ToUpper();
            set{
                if (value == ""){
                    throw new ArgumentException("Nome não pode ser vazio");
                }
                _nome = value;
            }
        }

        public List<Pessoa> Alunos { get; set; }

        public void Adicionar(Pessoa aluno) {
            if (Alunos == null){
                Alunos = new List<Pessoa>();
            }
            Console.WriteLine($"Aluno aqui: {aluno}");
            Alunos.Add(aluno);
        }

        public int Contar(){
            // int quantidade = Alunos.Count;
            // return quantidade;
            return Alunos.Count;
        }

        public bool Remover(Pessoa aluno){
            if (Alunos == null){
                Alunos = new List<Pessoa>();
            }
            return Alunos.Remove(aluno);
        }

        public void Listar(){
            if (Alunos == null){
                Alunos = new List<Pessoa>();
            }
            foreach(Pessoa aluno in Alunos){
                Console.WriteLine(aluno.NomeCompleto);
            };
        }


    }
}