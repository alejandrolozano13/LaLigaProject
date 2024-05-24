using Dominio.Modelos;
using Infra.Interfaces;

namespace Infra.Servicos
{
    public class ServicoJogador : IRepositoryJogador
    {
        public Task Adicionar(Jogador modelo)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Jogador modelo)
        {
            throw new NotImplementedException();
        }

        public Jogador ObterPeloNome(string nome)
        {
            throw new NotImplementedException();
        }

        public Jogador ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Jogador> ObterPorTime(int timeId)
        {
            throw new NotImplementedException();
        }

        public List<Jogador> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public Task Remover(Jogador modelo)
        {
            throw new NotImplementedException();
        }
    }
}