using FinancialPlanning.Busines;

using Microsoft.AspNetCore.Mvc;

namespace FinancialPlanning.Presentation
{
    public class HomeController() : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
