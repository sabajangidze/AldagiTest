using Domain.Abstractions;

namespace Domain.Entities;

public class Policy : IEntity<Guid>, IEntityAudit
{
    public Guid Id { get; set; }

    public string PolicyNumber { get; set; }

    public bool Status { get; set; }

    public DateTime FromDate { get; set; }

    public DateTime? EventDate { get;set; }

    public decimal? CurrentPaid { get; set; }

    public decimal? AllPaid { get; set; }

    public decimal? Payable { get; set; } 

    public DateTime? CancellDate { get; set; }

    public bool IsLoss { get; set; }

    public decimal? LossCount { get; set; }

    public decimal? PaidLoss { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? ModifiedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual Product Product { get; set; }

    public Guid ProductId { get; set; }

    public virtual Client Client { get; set; }

    public Guid ClientId { get; set; }

    public virtual ICollection<UsersPolicies> UsersPolicies { get; set; }
    public virtual ICollection<PoliciesSchemes> PoliciesSchemes { get; set; }
}
