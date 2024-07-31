using FinancialPlanning.Repository;

namespace FinancialPlanning.Presentation
{
    public static class RepositoryCollectionExtentions
    {
        public static void AddCustomRepository(this IServiceCollection services)
        {
            services.AddScoped<IExpenceCategoryRepository, ExpenseCategoryRepository>();
        }
    }
}
