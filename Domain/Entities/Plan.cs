using Domain.Abstractions;
using Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Plan : IEntity<Guid>, IEntityAudit
    {
        public Guid Id { get; set; }

        public ClientType Client { get; set; }

        public int Year { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? ModifiedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public User User { get; set; }

        public Guid UserId { get; set; }
    }
}
