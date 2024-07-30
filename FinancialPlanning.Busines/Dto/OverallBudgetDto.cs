namespace FinancialPlanning.Busines
{
    public class OverallBudgetDto
    {
        public int OverallBudgetId { get; set; }
        public decimal TotalIncome { get; set; }
        public decimal TotalExpense { get; set; }
        public decimal Balance { get; set; }
        public DateTime Period { get; set; }
    }
}
