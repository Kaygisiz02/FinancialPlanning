using FinancialPlanning.UI;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FinancialPlanning.UI
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
