namespace LedgerApi.Models
{
    public class Ledger
    {
        public Guid Id { get; private set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LedgerType { get; set; }
        public string Metadata { get; set; }
        public TimeSpan CreatedAt { get; set; }
        public TimeSpan UpdatedAt { get; set; }
    }
}
