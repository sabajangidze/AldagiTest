using Domain.Abstractions;

namespace Domain.Entities
{
    public class UsersPolicies : IEntity<Guid>
    {
        public Guid Id { get; set; }

        public virtual User User { get; set; }

        public Guid UserId { get; set; }

        public virtual Policy Policy { get; set; }

        public Guid PolicyId { get; set; }
    }
}
