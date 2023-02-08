using Domain.Abstractions;

namespace Domain.Entities;

public class AnnualPlan : IEntity<Guid>, IEntityAudit
{
    public Guid Id { get; set; }

    public string Month { get; set; }

    public int Year { get; set; }

    public decimal Value { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? ModifiedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual Plan Plan { get; set; }

    public Guid PlanId { get; set; }
}
