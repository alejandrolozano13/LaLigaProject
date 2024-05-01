using Infra.Interfaces;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult ObterTodos()
        {
            try
            {
                var time = _timeRepository.ObterTodos();
                return Ok(time);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("{id}")]
        public IActionResult ObterPorId(int id)
        {
            try
            {
                var time = _timeRepository.ObterPorId(id);
                return Ok(time);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}