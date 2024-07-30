using FinancialPlanning.Busines;

using Microsoft.AspNetCore.Mvc;

namespace FinancialPlanning.Presentation
{
    public class HomeController(IExpenceCategoryService expenceCategoryService  ) : Controller
    {
        IExpenceCategoryService _expenceCategoryService = expenceCategoryService;
        public IActionResult Index()
        {
            return View();
        }
    }
}
