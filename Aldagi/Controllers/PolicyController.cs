using Application.Services.Policies;
using Application.Services.Policies.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aldagi.Controllers;

[ApiController]
[Route("[controller]")]
public class PolicyController : ControllerBase
{
    private readonly PolicyService _policyService;

    public PolicyController(PolicyService policyService)
    {
        _policyService = policyService;
    }

    [HttpGet]
    public async Task<IActionResult> Get([FromBody] GetPolicyRequest request)
    {
        var result = await _policyService.GetPolicies(request);

        return Ok(result);
    }
}
