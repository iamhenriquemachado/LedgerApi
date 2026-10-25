namespace LedgerApi.Models
{
    public class Account
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string AcountType { get; set; }
        public string BalanceType { get; set; }
        public int SettledDebit { get; set; }
        public int SettledCredit { get; set; }
        public int PendingDebit { get; set; }
        public int PendingCredit { get; set; }
        public int PendingBalance { get; set; }
        public int AvailableDebit { get; set; }
        public int AvailableCredit { get; set; }
        public int AvailableBalance {get; set; }
        public string Metadata { get; set; }
        public int Version { get; set; }
        public Guid LedgerId { get; set; }
        public int CurrencyId { get; set; }
        public TimeSpan CreatedAt { get; set; }
        public TimeSpan UpdatedAt { get; set; }

    }
}
