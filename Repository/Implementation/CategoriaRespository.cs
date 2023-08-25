using Microsoft.EntityFrameworkCore;

namespace DON_KILO_BE.Repository.Implementation
{
    public class CategoriaRespository : ICategoriaRepository
    {
        private readonly DonKiloSgContext _context;

        public CategoriaRespository(DonKiloSgContext context)
        {
            _context = context;
        }

        public async Task<List<Categoria>> GetListCategorias()
        {
            try
            {
                return await _context.Categoria.ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
