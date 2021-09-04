using ProjetoAvalicacaoOnLineAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace ProjetoAvalicacaoOnLineAPI.Repository
{
    public sealed class AlunoRepository : IAlunoRepository
    {
        private readonly string _connectionString;

        public AlunoRepository()
        {
            _connectionString = "Server=tcp:avaliacao-online-server.database.windows.net,1433;Initial Catalog=AvalicaoOnlineDB;Persist Security Info=False;User ID=sergio;Password=!@123QWqwe;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        }
        public AlunoRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("AlunoDataServer");
        }

        //public int Insert(string nome, string cpf, DateTime dataNascimento, int step)
        public int Insert(Aluno aluno)
        {
            using var connection = new SqlConnection(_connectionString);

            var query = "Insert into Aluno (Nome, CPF, DataNascimento, Step) values (@Nome, @CPF, @DataNascimento, @Step)";

            //var result = connection.Execute(query, new { Nome = nome, CPF = cpf, DataNascimento = dataNascimento, Step = step });
            var result = connection.Execute(query, new { Nome = aluno.Nome, CPF = aluno.CPF, DataNascimento = aluno.DataNascimento, Step = aluno.Step });

            return result;
        }

        public IEnumerable<Aluno> ListAll()
        {
            using var connection = new SqlConnection(_connectionString);

            var alunoData = connection.Query<Aluno>("Select * From Aluno");

            return null;
        }
    }
}
