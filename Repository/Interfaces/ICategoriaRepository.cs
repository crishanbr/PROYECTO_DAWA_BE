namespace DON_KILO_BE.Repository.Interfaces
{
    public interface ICategoriaRepository
    {
        Task<List<Categoria>> GetListCategorias();
    }
}
