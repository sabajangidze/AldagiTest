namespace Domain.Abstractions;

public interface IGenericRepository<TEntity> where TEntity : class, IEntity<Guid>, IEntityAudit
{
    IQueryable<TEntity> GetAll();
    Task<TEntity?> GetByIdAsync(Guid id);
    Task InsertAsync(TEntity entity);
    void Update(TEntity entity);
    void Delete(TEntity entity);
    Task SaveAsync();
}
