namespace FinancialPlanning.Busines
{
    public interface IExpenceCategoryService
    {
        List<ExpenseCategoryDto> GetExpenseCategories();
        ExpenseCategoryDto GetExpenseCategoryById(int id);
        void UpdateExpenseCategory(ExpenseCategoryDto expenseCategoryDto);
        void DeleteExpenseCategory(int id);
    }
}
