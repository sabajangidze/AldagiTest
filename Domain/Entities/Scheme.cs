using Domain.Abstractions;

namespace Domain.Entities
{
    public class Scheme : IEntity<Guid>, IEntityAudit
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;
        
        public DateTime CreatedAt { get; set; }

        public DateTime? ModifiedAt { get; set; }

        public DateTime? DeletedAt { get; set; }
    }
}
