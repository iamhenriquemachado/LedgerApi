namespace LedgerApi.Models
{
    public class Transaction
    {
        public Guid Id { get; private set; }
        public string Description { get; set; }
        public string ExternalTransactionId { get; set; }
        public DateTime TransactionDate = DateTime.Now;
        public Guid JournalId { get; set; }
        public Guid LedgerId { get; set; }
        public int TransactionTypeId { get; set; }
        public int Version { get; set; }
        public string Metadata { get; set; }
        public Guid TransactionCodeId { get; set; }
        public int LayerId { get; set; }
        public DateTime PostedAt = DateTime.Now;
        public DateTime EffectiveAt { get; set; }
        public Guid ReversedByyTransactionId { get; set; }
        public Guid ReversesTransactionId { get; set; }
        public DateTime CreatedAt = DateTime.Now;
        public TimeSpan UpdatedAt { get; set; }


    }
}
