using Domain.Abstractions;
using Domain.Enums;

namespace Domain.Entities
{
    public class Client : IEntity<Guid>, IEntityAudit
    {
        public Guid Id { get; set; }

        public string ClientName { get; set; }

        public string ClientCode { get; set; }
        
        public string ContrAgentType { get; set; }

        public ClientType ClientType { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? ModifiedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public virtual ICollection<Policy> Policies { get; set; }
    }
}
