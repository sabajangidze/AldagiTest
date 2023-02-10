using Domain.Abstractions;

namespace Domain.Entities;

public class PolicyDetail : IEntity<Guid>, IEntityAudit
{
    public Guid Id { get; set; }

    public DateTime? PaymentDate { get; set; }

    public string OldPolicyNumber { get; set; }

    public decimal? CurrentPaid { get; set; }

    public DateTime? CancellDate { get; set; }

    public decimal? LossCount { get; set; }

    public decimal? PaidLoss { get; set; }

    public decimal? Rateprojected { get; set; }

    public bool? ArchiveStatus { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? ModifiedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual Policy Policy { get; set; }

    public Guid PolicyId { get; set; }
}
