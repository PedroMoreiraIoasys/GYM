using GYM_GetYourMuscles.Repositories.Interfaces;
using GYM_GetYourMuscles.Domain.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace GYM_GetYourMuscles.Repositories.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseClass
    {
        internal readonly Context.Context _context;
        internal DbSet<TEntity> _dbSet;

        protected BaseRepository(Context.Context context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public async Task Delete(long id)
        {
            var entityToDelete = Include().FirstOrDefault(c => c.Id == id);
            _dbSet.Remove(entityToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await Include().ToListAsync();
        }

        public async Task<TEntity> GetById(int id)
        {
            return await Include().FirstOrDefaultAsync(c => c.Id == id);
        }

        public IQueryable<TEntity> Include()
        {
            return _dbSet;
        }

        public async Task<TEntity> Insert(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
