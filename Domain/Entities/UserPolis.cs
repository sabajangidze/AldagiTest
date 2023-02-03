using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class UserPolis : IEntity<Guid>
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public virtual User User { get; set; }

        public Guid PolisId { get; set; }

        public virtual Polis Polis { get; set; }
    }
}
