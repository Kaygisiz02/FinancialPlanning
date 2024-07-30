namespace FinancialPlanning.Busines
{
    public class BudgetReportDto
    {
        public int BudgetReportId { get; set; }
        public int OverallBudgetId { get; set; }
        public DateTime GeneratedOn { get; set; }
        public required string ReportContent { get; set; }
    }
}
