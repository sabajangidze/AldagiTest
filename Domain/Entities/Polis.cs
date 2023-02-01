using Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Polis : IEntity<Guid>, IEntityAudit
    {
        public Guid Id { get; set; }

        public string PolisNumber { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime EventDate { get;set; }

        public double CurrentPaid { get; set; } // Do we need nullable?

        public double AllPaid { get; set; }

        public double Payable { get; set; } // decimal for money

        public DateTime? CancellDate { get; set; }

        public bool IsLoss { get; set; }

        public double LossCount { get; set; }

        public double PaidLoss { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? ModifiedAt { get; set; }

        public DateTime? DeletedAt { get; set; }
    }
}
