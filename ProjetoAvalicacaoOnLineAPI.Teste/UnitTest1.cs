using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Newtonsoft.Json;
using ProjetoAvalicacaoOnLineAPI.Controller;
using ProjetoAvalicacaoOnLineAPI.Domain;
using ProjetoAvalicacaoOnLineAPI.Repository;
using System.IO;
using System.Net.Http;
using System.Text;

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
            aluno.Nome = "Luiz";
            aluno.CPF = "222.333.444-56";
            aluno.DataNascimento = new System.DateTime(1993, 09, 29);
            aluno.Step = 2;

            Assert.IsNotNull(repository.Insert(aluno));
        }

        
    }
}
