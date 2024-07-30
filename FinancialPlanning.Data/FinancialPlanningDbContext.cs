namespace FinancialPlanning
{
    public class FinancialPlanningDbContext:DbContext
    {
        public FinancialPlanningDbContext(DbContextOptions<FinancialPlanningDbContext> options):base(options)
        {
            
        }
        public DbSet<BudgetReport> BudgetReports { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<ExpenseCategory> ExpenseCategories { get; set; }
        public DbSet<Income> Incomes { get; set; }
        public DbSet<IncomeCategory> IncomeCategories { get; set; }
        public DbSet<OverallBudget> OverallBudgets { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    }
}
