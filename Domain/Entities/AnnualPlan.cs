using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class AnnualPlan : IEntity<Guid>, IEntityAudit
    {
        public Guid Id { get; set; }

        public string Month { get; set; }

        public int Year { get; set; }

        public int Value { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? ModifiedAt { get; set; }

        public DateTime? DeletedAt { get; set; }

        public virtual Plan Plan { get; set; }

        public Guid PlanId { get; set; }
    }
}
