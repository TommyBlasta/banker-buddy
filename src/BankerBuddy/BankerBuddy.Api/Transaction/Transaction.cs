using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankerBuddy.Api.Transaction
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid Source { get; set; }
        public decimal BalanceChange { get; set; }
        public DateTime DateOfTransaction { get; set; }
        public IList<Guid>? CategoryIds { get; set; }
    }
}
