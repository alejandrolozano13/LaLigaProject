using Infra.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoPessoalUI5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadioController : ControllerBase
    {
        private readonly IRepositoryEstadio _repositoryEstadio;

        public EstadioController(IRepositoryEstadio repositoryEstadio)
        {
            _repositoryEstadio = repositoryEstadio;
        }

        [HttpGet]
        public IActionResult ObterTodos()
        {
            try
            {
                var estadio = _repositoryEstadio.ObterTodos();
                return Ok(estadio);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("timeId/{id}")]
        public IActionResult ObterEstadioPorTimeId(int id)
        {
            try
            {
                var estadio = _repositoryEstadio.ObterPorTimeId(id);
                return Ok(estadio);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}