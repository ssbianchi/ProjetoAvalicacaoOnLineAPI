using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjetoAvalicacaoOnLineAPI.Domain;
using ProjetoAvalicacaoOnLineAPI.Repository;

namespace ProjetoAvalicacaoOnLineAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly ILogger<AlunoController> _logger;
        private readonly IAlunoRepository _alunoRepository;

        public AlunoController(ILogger<AlunoController> logger, IAlunoRepository alunoRepository)
        {
            _logger = logger;
            _alunoRepository = alunoRepository;
        }

        [HttpGet]
        public IActionResult GetAllData()
        {
            try
            {
                var data = _alunoRepository.ListAll();

                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao tentar obter dados");
                return new StatusCodeResult(500);
            }
        }

        [HttpPost]
        public IActionResult SetData([FromBody] Aluno aluno)
        {
            try
            {
                var result = _alunoRepository.Insert(aluno);

                return Ok();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Erro ao tentar inserir dados");
                return new StatusCodeResult(500);
            }
        }
    }
}
