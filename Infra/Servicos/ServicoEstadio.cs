using Dominio.Modelos;
using Infra.Interfaces;

namespace Infra.Servicos
{
    public class ServicoEstadio : IRepositoryEstadio
    {
        public Task Adicionar(Estadio modelo)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Estadio modelo)
        {
            throw new NotImplementedException();
        }

        public Estadio ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public Estadio ObterPorTimeId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Estadio> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public Task Remover(Estadio modelo)
        {
            throw new NotImplementedException();
        }
    }
}