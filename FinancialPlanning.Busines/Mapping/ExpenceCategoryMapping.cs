namespace FinancialPlanning.Busines
{
    public class ExpenceCategoryMapping:Profile
    {
        public ExpenceCategoryMapping()
        {
            CreateMap<ExpenseCategory, ExpenseCategoryDto>().ReverseMap();
        }
    }
}
