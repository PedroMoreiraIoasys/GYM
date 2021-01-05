using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GYM_GetYourMuscles.Repositories.Interfaces
{
    public interface IBaseRepository<TEntity>
    {
        Task<TEntity> GetById(int id);
        Task<List<TEntity>> GetAll(int id);
        Task<TEntity> Update(TEntity entity);
        Task<TEntity> Insert(TEntity entity);
        Task Delete(int id);
        IQueryable<TEntity> Include();
    }
}
