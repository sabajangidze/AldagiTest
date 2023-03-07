using Dapper;
using Domain.Abstractions;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;

namespace Infrastructure.Repositories;

public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
{
    private readonly DapperContext _context;

    public GenericRepository(DapperContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<T>> Query<T>(string table)
    {
        var query = $"SELECT * FROM {table}";

        using (var connection = _context.CreateConnection())
        {
            var results = await connection.QueryAsync<T>(query);

            return results.ToList();
        }
    }

    public async Task<T> GetById<T>(string table, Guid id)
    {
        var query = $"SELECT * FROM {table} WHERE Id = @Id";

        using (var connection = _context.CreateConnection())
        {
            var result = await connection.QueryFirstOrDefaultAsync<T>(query, new { id });

            return result;
        }
    }

    public async Task<IEnumerable<T>> CustomQuery<T>(string query)
    {
        using (var connection = _context.CreateConnection())
        {
            var results = await connection.QueryAsync<T>(query);

            return results.ToList();
        }
    }
}
