namespace BankerBuddy.Model
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid Source { get; set; }
        public decimal BalanceChange { get; set; }
        public DateTime DateOfTransaction { get; set; }
        public IList<TransactionCategory>? Categories { get; set; }
    }
}