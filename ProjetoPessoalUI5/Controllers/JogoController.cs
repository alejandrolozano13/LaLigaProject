using Infra.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoPessoalUI5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogoController : ControllerBase
    {
        private readonly IRepositoryJogo _repositoryJogo;
        private readonly ITimeRepository _timeRepository;

        public JogoController(IRepositoryJogo repositoryJogo, ITimeRepository timeRepository)
        {
            _repositoryJogo = repositoryJogo;
            _timeRepository = timeRepository;
        }

        [HttpGet]
        public OkObjectResult ObterTodos()
        {
            var jogos = _repositoryJogo.ObterTodos();
            var jogosDefinidos = new List<Object>();

            jogos.ForEach(x =>
            {
                var timeLocal = _timeRepository.ObterPorId(x.TimeLocalId).Nome;
                var timeVisitante = _timeRepository.ObterPorId(x.TimeVisitanteId).Nome;
                var escudoTimeLocal = _timeRepository.ObterPorId(x.TimeLocalId).FotoEscudo;
                var escudoTimeVisitante = _timeRepository.ObterPorId(x.TimeVisitanteId).FotoEscudo;

                var jogo = new
                {
                    timeLocal = timeLocal,
                    timeVisitante = timeVisitante,
                    escudoTimeLocal = escudoTimeLocal,
                    escudoTimeVisitante = escudoTimeVisitante
                };

                jogosDefinidos.Add(jogo);
            });
            return Ok(jogosDefinidos);
        }
    }
}