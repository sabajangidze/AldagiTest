using Application.Services.Policies.Models;
using Domain.Abstractions;
using Domain.Entities;

namespace Application.Services.Policies;

public class PolicyService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IGenericRepository<Policy> _genericRepository;

    public PolicyService(IUnitOfWork unitOfWork, IGenericRepository<Policy> genericRepository)
    {
        _unitOfWork= unitOfWork;
        _genericRepository= genericRepository;
    }

    public async Task<IEnumerable<Policy>> GetPolicies()
    {
        return await _genericRepository.Query<Policy>("Policies");
    }

    //public async Task<Policy> GetPolicy(Guid id)
    //{
    //    var policies = await _unitOfWork.GetById(id);
    //    var temp = GetQuery().Where(x => x.Id == id);
    //    return policies;
    //}

    private IQueryable<Policy> GetQuery()
    {
        return _unitOfWork.Query<Policy>().Where(x => x.DeletedAt == null);
    }
}
