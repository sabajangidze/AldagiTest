using Domain.Abstractions;

namespace Domain.Entities;

public class Polis : IEntity<Guid>, IEntityAudit
{
    public Guid Id { get; set; }

    public string PolisNumber { get; set; }

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

    public virtual ICollection<UserPolis> UserPolises { get; set; }
}
