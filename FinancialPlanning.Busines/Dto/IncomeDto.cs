namespace FinancialPlanning.Busines
{
    public class IncomeDto
    {
        public int IncomeId { get; set; }
        public decimal Amount { get; set; }
        public int IncomeCategoryId { get; set; }
        public required string IncomeCategoryName { get; set; }  
        public DateTime Date { get; set; }
        public required string Description { get; set; }
        public string? Note { get; set; }
    }
}
