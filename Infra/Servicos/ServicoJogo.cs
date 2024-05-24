using Dominio.Modelos;
using Infra.Interfaces;

namespace Infra.Servicos
{
    public class ServicoJogo : IRepositoryJogo
    {
        public Task Adicionar(Jogo modelo)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Jogo modelo)
        {
            throw new NotImplementedException();
        }

        public Jogo ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Jogo> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public Task Remover(Jogo modelo)
        {
            throw new NotImplementedException();
        }
    }
}