namespace FinancialPlanning.Data
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public required string Description { get; set; }
        public string? Note { get; set; }
        // Indicator if transaction is income or expense
        public bool IsIncome { get; set; }
    }
}
