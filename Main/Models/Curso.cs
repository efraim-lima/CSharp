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

        public List<Aluno> Alunos { get; set; }

        public void Adicionar(Aluno aluno) {
            if (Alunos == null){
                Alunos = new List<Aluno>();
            }
            Console.WriteLine($"Aluno aqui: {aluno}");
            Alunos.Add(aluno);
        }

        public int Contar(){
            // int quantidade = Alunos.Count;
            // return quantidade;
            return Alunos.Count;
        }

        public bool Remover(Aluno aluno){
            if (Alunos == null){
                Alunos = new List<Aluno>();
            }
            return Alunos.Remove(aluno);
        }

        public void Listar(){
            if (Alunos == null){
                Alunos = new List<Aluno>();
            }
            foreach(Aluno aluno in Alunos){
                Console.WriteLine(aluno.NomeCompleto);
            };
        }


    }
}