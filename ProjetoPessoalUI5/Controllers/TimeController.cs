using Dominio.Modelos;
using Infra.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.Xml;

namespace ProjetoPessoalUI5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TimeController : ControllerBase
    {
        private readonly ITimeRepository _timeRepository;

        public TimeController(ITimeRepository timeRepository)
        {
            _timeRepository = timeRepository;
        }

        [HttpGet]
        public OkObjectResult ObterTodos()
        {
            var time = _timeRepository.ObterTodos();
            return Ok(time);
        }

        [HttpGet("{id}")]
        public OkObjectResult ObterPorId(int id)
        {
            var time = _timeRepository.ObterPorId(id);
            return Ok(time);
        }

        [HttpPost("adicionar-time")]
        public async Task<CreatedResult> Adicionar([FromBody] Time time)
        {
            var uri = Url.Action("adicionar-time", new { id = time.Id });
            await _timeRepository.Adicionar(time);
            return Created(uri, time);
        }

        [HttpDelete]
        public NoContentResult Remover(Time time)
        {
            _timeRepository.Remover(time);
            return NoContent();
        }
    }
}