using Infra.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoPessoalUI5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogadorController : ControllerBase
    {
        private readonly IRepositoryJogador _repositoryJogador;

        public JogadorController(IRepositoryJogador repositoryJogador)
        {
            _repositoryJogador = repositoryJogador;
        }

        [HttpGet]
        public IActionResult ObterTodos()
        {
            try
            {
                var jogador = _repositoryJogador.ObterTodos();
                return Ok(jogador);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("timeId/{id}")]
        public IActionResult ObterJogadorPorTime(int id)
        {
            try
            {
                var jogadores = _repositoryJogador.ObterPorTime(id);
                return Ok(jogadores);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet("obter-pelo-nome/{nome}")]
        public OkObjectResult ObterJogador(string nome)
        {
            return Ok(_repositoryJogador.ObterPeloNome(nome));
        }
    }
}