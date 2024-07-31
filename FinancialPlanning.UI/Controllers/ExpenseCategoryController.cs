using AutoMapper;
using FinancialPlanning.Busines;
using Microsoft.AspNetCore.Mvc;

namespace FinancialPlanning.Presentation
{
    public class ExpenseCategoryController(IExpenceCategoryService expenceCategoryService) : Controller
    {
        readonly IExpenceCategoryService _expenceCategoryService = expenceCategoryService;
      
        public IActionResult Index()
        {
            var expenceCategoryDto=_expenceCategoryService.GetExpenseCategories();

            return View();
        }
        [HttpGet]
        public IActionResult GetExpenseCategoryById(int id) 
        {
            var expenceCategory = _expenceCategoryService.GetExpenseCategoryById(id);
            return View(expenceCategory);
        }
        [HttpPost]
        public IActionResult UpdateExpenseCategory(ExpenseCategoryDto expenseCategoryDto)
        {
            _expenceCategoryService.UpdateExpenseCategory(expenseCategoryDto);
            return View();
        }
        [HttpPost]
        public ActionResult DeleteExpenseCategory(int id) 
        {
            _expenceCategoryService.DeleteExpenseCategory(id);
            return View();
        }
    }
}
