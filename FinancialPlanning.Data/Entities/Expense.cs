using FinancialPlanning.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlanning
{
    public class Expense
    {
        public int ExpenseId { get; set; }
        public decimal Amount { get; set; }
        // Foreign key to ExpenseCategory
        public int ExpenseCategoryId { get; set; }
        public ExpenseCategory ExpenseCategory { get; set; }
        public DateTime Date { get; set; }
        public required string Description { get; set; }
        public string? Note { get; set; }

    }
}
