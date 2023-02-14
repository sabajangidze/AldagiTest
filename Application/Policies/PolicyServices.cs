using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Abstractions;
using Domain.Entities;

namespace Application.Policies;

public class PolicyService
{
    private readonly IUnitOfWork _unitOfWork;

    public PolicyService(IUnitOfWork unitOfWork)
    {
        _unitOfWork= unitOfWork;
    }  

    public async Task<IEnumerable<Policy>> GetPolicies()
    {
        var policies = GetQuery();
        return policies;
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
