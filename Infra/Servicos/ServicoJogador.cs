using Dominio.Modelos;
using Infra.Interfaces;

namespace Infra.Servicos
{
    public class ServicoJogador : IRepositoryJogador
    {
        public void Adicionar(Jogador modelo)
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

        public void Remover(Jogador modelo)
        {
            throw new NotImplementedException();
        }
    }
}