namespace FinancialPlanning.Data 
{
    public class Income
    {
        public int IncomeId { get; set; }
        public decimal Amount { get; set; }

        // Foreign key to IncomeCategory
        public int IncomeCategoryId { get; set; }
        public IncomeCategory IncomeCategory { get; set; }
        public DateTime Date { get; set; }
        public required string Description { get; set; }
        public string? Note { get; set; }
    }
}
