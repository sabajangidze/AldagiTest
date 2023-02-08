using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class PoliciesSchemes :IEntity<Guid>
    {
        public Guid Id { get; set; }

        public virtual Policy Policy { get; set; }

        public Guid PolicyId { get; set; }

        public virtual Scheme Scheme { get; set; }

        public Guid SchemeId { get; set; }
    }
}
