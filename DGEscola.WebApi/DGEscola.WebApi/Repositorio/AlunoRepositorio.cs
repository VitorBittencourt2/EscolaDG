using Dapper;
using DGEscola.WebApi.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace DGEscola.WebApi.Repositorio
{
    public class AlunoRepositorio
    {
        public string ConnectionString { get; set; }
        public AlunoRepositorio() { }

        public Aluno Salvar(Aluno aluno)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                string dbCommand = "insert into alunos(cpf,nome,idade)values(@cpf, @nome, @idade)";

                var id = conn.QueryFirstOrDefault<int>(dbCommand, new
                {
                    cpf = aluno.Cpf,
                    nome = aluno.Nome,
                    idade = aluno.Idade
                });

                aluno.Id = id;
            }

            return aluno;
        }

        public Aluno Atualizar(Aluno aluno)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                string dbCommand = "update alunos set cpf=@cpf, nome=@nome, idade=@idade where id=@id";

                var id = conn.QueryFirstOrDefault<int>(dbCommand, new
                {
                    cpf = aluno.Cpf,
                    nome = aluno.Nome,
                    idade = aluno.Idade
                });

                aluno.Id = id;
            }
            return aluno;
        }

        public Aluno Excluir(Aluno aluno)
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                string dbCommand = "delete from alunos where id=@id";

                var id = conn.QueryFirstOrDefault<int>(dbCommand, new
                {
                    cpf = aluno.Cpf,
                    nome = aluno.Nome,
                    idade = aluno.Idade
                });

                aluno.Id = id;
            }

            return aluno;
        }

      /*  public Aluno Obter(Aluno aluno) 
        {
            using (var conn = new SqlConnection(ConnectionString))
            {
                string dbCommand = "select cpf, nome, idade from alunos where id=@id ";

                var id = conn.QueryFirstOrDefault<int>(dbCommand, new
                {
                    cpf = aluno.Cpf,
                    nome = aluno.Nome,
                    idade = aluno.Idade
                });
            }

            return aluno;
        }*/

        public IEnumerable<Aluno> Listar()
        {

            var alunos = new List<Aluno>();
            Aluno al = new Aluno();

            using (var conn = new SqlConnection(ConnectionString))
            {
                string dbCommand = "select cpf, nome, idade from alunos where id=@id ";

                var id = conn.QueryFirstOrDefault(dbCommand, new
                {
                    cpf = al.Cpf,
                    nome = al.Nome,
                    idade = al.Idade

                });
                alunos.Add(id);

            }

            return alunos;
        }
    }
}
