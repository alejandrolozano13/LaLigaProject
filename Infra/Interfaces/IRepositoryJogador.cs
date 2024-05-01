using Dominio.IModelRepository;
using Dominio.Modelos;

namespace Infra.Interfaces
{
    public interface IRepositoryJogador : IModelRepository<Jogador>
    {
        List<Jogador> ObterPorTime(int timeId);
        Jogador ObterPeloNome(string nome);
    }
}