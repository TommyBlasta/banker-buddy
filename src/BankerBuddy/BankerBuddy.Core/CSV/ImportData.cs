using BankerBuddy.Model;

namespace BankerBuddy.Core.CSV
{
    public class ImportData
    {
        public string MetaData { get; set; } = null!;
        public IList<Transaction>? Transactions {get;set;}
    }
}