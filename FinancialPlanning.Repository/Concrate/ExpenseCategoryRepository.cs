namespace FinancialPlanning.Repository
{
    public class ExpenseCategoryRepository:Repository<ExpenseCategory>,IExpenceCategoryRepository
    {
        public ExpenseCategoryRepository(FinancialPlanningDbContext dbConttext):base(dbConttext)
        {
            
        }
    }
}
