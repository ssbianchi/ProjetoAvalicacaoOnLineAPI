using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjetoAvalicacaoOnLineAPI.Domain;
using ProjetoAvalicacaoOnLineAPI.Repository;

namespace ProjetoAvalicacaoOnLineAPI.Teste
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void ListAlunoTest()
        {
            var repository = new AlunoRepository();

            Assert.IsNotNull(repository.ListAll());
        }

        [TestMethod]
        public void InsertAlunoTest()
        {
            var repository = new AlunoRepository();
            var aluno = new Aluno();
            aluno.Nome = "Brendon";
            aluno.CPF = "222.333.444-56";
            aluno.DataNascimento = new System.DateTime(1993, 09, 29);
            aluno.Step = 2;

            Assert.IsNotNull(repository.Insert(aluno));
        }
    }
}
