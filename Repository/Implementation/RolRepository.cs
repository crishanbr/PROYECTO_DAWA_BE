using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DON_KILO_BE.Repository.Implementation
{
    public class RolRepository : IRolRepository
    {
        private readonly DonKiloSgContext _dbContext;

        public RolRepository(DonKiloSgContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<List<Rol>> Lista()
        {
            try
            {
                return await _dbContext.Rols.ToListAsync();
            }
            catch
            {
                throw;
            }
        }
    }
}
