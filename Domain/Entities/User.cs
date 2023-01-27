using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class User : IEntity<Guid>, IEntityAudit
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PersonalId { get; set; }

        public string AccountNumber { get; set; }

        public bool IsEmployee { get; set; }

        public bool IsTaxPayer { get; set; }
        
        public bool IsPensioPayer { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? ModifiedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public virtual Scheme Scheme { get; set; }

        public Guid SchemeId { get; set; }

        public virtual Role Role { get; set; }

        public Guid RoleId { get; set; }

        public virtual ICollection<Plan> Plans { get; set; }
    }
}
