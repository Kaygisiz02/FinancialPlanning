namespace FinancialPlanning.Data
{
    public class ExpenseCategory
    {
        public int ExpenseCategoryId { get; set; }
        public required string ExpenseCategoryName { get; set; }
        public required string Description { get; set; }

        // Foreign key to Expense
        public List<Expense> Expenses { get; set; }
    }
}
