namespace FinancialPlanning.Busines
{
    public class TransactionDto
    {
        public int TransactionId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public required string Description { get; set; }
        public string? Note { get; set; }
        public int UserId { get; set; }
        public bool IsIncome { get; set; }
    }
}
