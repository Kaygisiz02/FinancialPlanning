namespace FinancialPlanning.Data
{
    public class IncomeCategory
    {
        public int IncomeCategoryId { get; set; }
        public required string IncomeCategoryName { get; set; }
        public required string Description { get; set; }

        // Foreign key to Income
        public List<Income> Incomes { get; set; }
    }
}
