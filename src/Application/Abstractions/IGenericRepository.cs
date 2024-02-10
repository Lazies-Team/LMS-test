namespace Application.Abstractions
{
    public interface IGenericRepository<TEntity>
    {
        ValueTask<TEntity> InsertAsync(TEntity entity);
        IQueryable<TEntity> SelectAll();
        ValueTask<TEntity> SelectByIdAsync(long id);
        ValueTask<TEntity> UpdateAsync(TEntity entity);
        ValueTask<TEntity> DeleteAsync(long id);
    }
}
