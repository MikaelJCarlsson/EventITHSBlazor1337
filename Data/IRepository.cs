using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ITHSManagement.Models;

namespace ITHSManagement.Data
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<int> Delete(object id);
        Task<int> Delete(TEntity entityToDelete);
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> filter = null, Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null, string includeProperties = "");
        TEntity GetByID(object id);
        Task<int> Insert(TEntity entity);
        Task<int> Update(TEntity entityToUpdate);
    }
}
