using ProjetoAvalicacaoOnLineAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoAvalicacaoOnLineAPI.Repository
{
    public interface IAlunoRepository
    {
        public IEnumerable<Aluno> ListAll();

        //public int Insert(string nome, string cpf, DateTime dataNascimento, int step);
        public int Insert(Aluno aluno);
    }
}
