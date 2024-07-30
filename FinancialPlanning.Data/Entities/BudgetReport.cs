namespace FinancialPlanning.Data
{

    public class BudgetReport
    {
        public int BudgetReportId { get; set; }

        // Foreign key to OverallBudget
        public int OverallBudgetId { get; set; }
        public OverallBudget Budget { get; set; }

        public DateTime GeneratedOn { get; set; }
        public required string ReportContent { get; set; }
    }
}
