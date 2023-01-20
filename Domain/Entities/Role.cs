using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Role : IEntity<Guid>, IEntityAudit
    {
        public Guid Id { get; set; }

        public string Type { get; set; }

        public int Hierarchy { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? ModifiedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public virtual User User { get; set; }

        public Guid UserId { get; set; }
    }
}
