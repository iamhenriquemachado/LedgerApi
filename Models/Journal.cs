namespace LedgerApi.Models
{
    public class Journal
    {
        public Guid Id { get; private set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int StatusId { get; set; }
        public string JournalType { get; set; }
        public string Metadata { get; set; }
        public Guid LedgerId { get; set; }
        public TimeSpan CreatedAt { get; set; }
        public TimeSpan UpdatedAt { get; set; }

    }
}
