using FinancialPlanning.Busines;

namespace FinancialPlanning.Presentation
{
    public static class ServiceCollectionExtensions
    {
        public static void AddCustomServices(this IServiceCollection services)
        {
            services.AddScoped<IExpenceCategoryService, ExpenseCategoryService>(); ;
        }
    }
}
