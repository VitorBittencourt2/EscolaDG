using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DGEscola.WebApi.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public int Cpf { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }

        public Aluno() { }

        public Aluno(int Id, int Cpf, string Nome, int Idade)
        {
            this.Id = Id;
            this.Cpf = Cpf;
            this.Nome = Nome;
            this.Idade = Idade;
        }
    }
}
