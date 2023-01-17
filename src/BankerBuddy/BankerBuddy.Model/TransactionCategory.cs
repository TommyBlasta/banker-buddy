using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankerBuddy.Model
{
    public class TransactionCategory
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; } = null!;
        public string Description { get; set; } = null!;
        public IList<TransactionCategoryKey> TransactionCategoryKeys { get; set; } = null!;

    }
}
