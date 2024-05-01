using Dominio.IModelRepository;
using Dominio.Modelos;

namespace Infra.Interfaces
{
    public interface IRepositoryEstadio : IModelRepository<Estadio>
    {
        Estadio ObterPorTimeId(int id);
    }
}