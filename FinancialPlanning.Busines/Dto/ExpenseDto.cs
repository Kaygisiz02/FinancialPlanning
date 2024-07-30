namespace FinancialPlanning.Busines
{
    public class ExpenseDto
    {
        public int ExpenseId { get; set; }
        public decimal Amount { get; set; }
        public int ExpenseCategoryId { get; set; }
        public string ExpenseCategoryName { get; set; }  // Adding Category Name for easier use
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string? Note { get; set; }
    }
}
