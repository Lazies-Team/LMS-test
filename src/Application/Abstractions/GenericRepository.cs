﻿using System.Linq.Expressions;

namespace Application.Abstractions
{
    public interface GenericRepository<TEntity>
    {
        ValueTask<TEntity> InsertAsync(TEntity entity);
        IQueryable<IList<TEntity>> SelectAll();
        ValueTask<TEntity> SelectByIdAsync(long id);
        ValueTask<TEntity> UpdateAsync(TEntity entity);
        ValueTask<TEntity> DeleteAsync(TEntity entity);
    }
}
