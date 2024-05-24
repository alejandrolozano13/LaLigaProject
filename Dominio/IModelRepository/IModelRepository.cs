namespace Dominio.IModelRepository
{
    public interface IModelRepository<T> where T : class
    {
        List<T> ObterTodos();
        T ObterPorId(int id);
        Task Adicionar(T modelo);
        Task Remover (T modelo);
        void Atualizar (T modelo);
    }
}
