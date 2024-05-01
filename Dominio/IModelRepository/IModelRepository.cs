namespace Dominio.IModelRepository
{
    public interface IModelRepository<T> where T : class
    {
        List<T> ObterTodos();
        T ObterPorId(int id);
        void Adicionar(T modelo);
        void Remover (T modelo);
        void Atualizar (T modelo);
    }
}
