using Domain.Abstractions;

namespace Domain.Entities;

public class UsersSchemes : IEntity<Guid>
{
    public Guid Id { get; set; }

    public virtual User User { get; set; }

    public Guid UserId { get; set; }

    public virtual Scheme Scheme { get; set; }

    public Guid SchemeId { get; set; }
}
