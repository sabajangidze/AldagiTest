using Domain.Abstractions;
using Microsoft.EntityFrameworkCore.Storage;

namespace Infrastructure.Repositories;

internal class DbTransaction : ITransaction
{
    private readonly IDbContextTransaction _transaction;

    public DbTransaction(IDbContextTransaction transaction)
    {
        _transaction = transaction;
    }

    public void Commit()
    {
        _transaction.Commit();
    }

    public void RollBack()
    {
        _transaction.Rollback();
    }

    public void Dispose()
    {
        _transaction.Dispose();
    }
}
