using Domain.Abstractions;

namespace Domain.Entities;

public class Policy : IEntity<Guid>, IEntityAudit
{
    public Guid Id { get; set; }

    public string PolicyNumber { get; set; }

    public bool Status { get; set; }

    public DateTime? PaymentDate { get; set; }

    public DateTime FromDate { get; set; }

    public DateTime EventDate { get;set; }

    public bool IsLoss { get; set; }

    public string PremiumCurrency { get; set; }

    public string LimitCurrency { get; set; }

    public string CurName { get; set; }

    public decimal SumInsured { get; set; }

    public string Intallment { get; set; }

    public int EventOrderNo { get; set; }

    public string PayType { get; set; }

    public string Comission { get; set; }

    public string Segment { get; set; }

    public string SellSpot { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? ModifiedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public virtual License License { get; set; }

    public virtual Client Client { get; set; }

    public virtual PolicyDetail PolicyDetail { get; set; }

    public Guid PolicyDetailId { get; set; }

    public virtual ICollection<User> Users { get; set; }
    public virtual ICollection<Scheme> Schemes { get; set; }
}
