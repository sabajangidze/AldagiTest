using Application.Services.Policies.Models;
using Domain.Abstractions;
using Domain.Entities;

namespace Application.Services.Policies;

public class PolicyService
{
    private readonly IUnitOfWork _unitOfWork;

    public PolicyService(IUnitOfWork unitOfWork)
    {
        _unitOfWork= unitOfWork;
    }  

    //public async Task<IEnumerable<Policy>> GetPolicies(GetPolicyRequest request)
    //{
    //    var policies = GetQuery();

    //    var response = _mapper.Map<GetPolicyResponse>(policies);

    //    return response;
    //}
    
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
