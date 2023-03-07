namespace Domain.Abstractions;

public interface IGenericRepository<TEntity> where TEntity : class
{
    Task<IEnumerable<T>> Query<T>(string table);

    Task<T> GetById<T>(string table, Guid id);

    Task<IEnumerable<T>> CustomQuery<T>(string query);
}
