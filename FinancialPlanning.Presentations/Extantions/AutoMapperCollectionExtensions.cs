using FinancialPlanning.Busines;

namespace FinancialPlanning.Presentation
{
    public static class AutoMapperCollectionExtensions
    {
        public static void AddAutoMapperCustom(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ExpenceCategoryMapping));
        }
       
    }
}
