using FinancialPlanning.Busines;
using FinancialPlanning.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanning.Busines
{
    public class ExpenseCategoryService(IExpenceCategoryRepository expenseCategoryRepository, IMapper mapper) : IExpenceCategoryService
    {
        readonly IExpenceCategoryRepository _expenseCategoryRepository = expenseCategoryRepository;
        readonly IMapper _mapper = mapper;
        public List<ExpenseCategoryDto> GetExpenseCategories()
        {
            List<ExpenseCategory> expenseCategory = _expenseCategoryRepository.GetAll();
            List<ExpenseCategoryDto> expenseCategoryDtos = _mapper.Map<List<ExpenseCategoryDto>>(expenseCategory);
            return expenseCategoryDtos;
        }

        public ExpenseCategoryDto GetExpenseCategoryById(int id)
        {
            ExpenseCategory expenseCategory =  _expenseCategoryRepository.Get(id);
            ExpenseCategoryDto expenseCategoryDtos=_mapper.Map<ExpenseCategoryDto>(expenseCategory);
            return expenseCategoryDtos;
        }

        public void UpdateExpenseCategory(ExpenseCategoryDto expenseCategoryDto)
        {
            var expenseCategoryDtos = _mapper.Map<ExpenseCategory>(expenseCategoryDto);
            _expenseCategoryRepository.Update(expenseCategoryDtos);
           
        }
        public void DeleteExpenseCategory(int id)
        {
            var expenseCategory = _expenseCategoryRepository.Get(id);
            _expenseCategoryRepository.Remove(id);
        }


    }
}
