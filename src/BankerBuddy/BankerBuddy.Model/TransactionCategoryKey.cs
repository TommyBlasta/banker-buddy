using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankerBuddy.Model
{
    /// <summary>
    /// Defines connection between the Transaction category and Party for a certain user. 
    /// This enables us to link the transaction to it's category automatically.
    /// </summary>
    public class TransactionCategoryKey
    {
        public Guid UserId { get; set; }    
        public Guid PartyId { get; set; }
        public Guid TransactionCategoryId { get; set; }

    }
}
