using Domain.Abstractions;
using Domain.Enums;

namespace Domain.Entities;

public class Plan : IEntity<Guid>, IEntityAudit
{
    public Guid Id { get; set; }

    public ClientType ClientType { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? ModifiedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual User User { get; set; }

    public Guid UserId { get; set; }

    public virtual License License { get; set; }

    public Guid? LicenseId { get; set; }

    public virtual IEnumerable<AnnualPlan> AnnualPlans { get; set; }
}
