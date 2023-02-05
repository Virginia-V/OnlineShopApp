using Microsoft.EntityFrameworkCore;
using OnlineShop.Dal.Interfaces;
using OnlineShop.Domain;
using System.Linq.Expressions;

namespace OnlineShop.Dal.Repositories
{
    public class EFCoreRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly OnlineShopDbContext _context;

        public EFCoreRepository(OnlineShopDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(TEntity entity)
        {
            await _context.Set<TEntity>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<TEntity>> GetAllAsync()
        {
            return await _context.Set<TEntity>().ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _context.Set<TEntity>().FindAsync(id);
        }

        public async Task<IEnumerable<TEntity>> GetWhereAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _context.Set<TEntity>().Where(predicate).ToListAsync();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
