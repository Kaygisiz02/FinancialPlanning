namespace FinancialPlanning.Busines
{
    public class ExpenseCategoryDto
    {
        public int ExpenseCategoryId { get; set; }
        public required string ExpenseCategoryName { get; set; }
        public required string Description { get; set; }
    }
}
