namespace FinancialPlanning.Data
{
    public class OverallBudget
    {
        public int OverallBudgetId { get; set; }
        public decimal TotalIncome { get; set; }
        public decimal TotalExpense { get; set; }
        public decimal Balance { get; set; }
        public DateTime Period { get; set; }

        // Foreign key to Income and Expense
        public List<Income> Incomes { get; set; }
        public List<Expense> Expenses { get; set; }
    }
}
