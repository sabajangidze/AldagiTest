using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product : IEntity<Guid>, IEntityAudit
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public double MonthlyPercent { get; set; }

        public double QuarterPercent { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? ModifiedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public virtual Scheme Scheme { get; set; }

        public Guid SchemeId { get; set; }

        public virtual ICollection<Role> Roles { get; set; }
    }
}
