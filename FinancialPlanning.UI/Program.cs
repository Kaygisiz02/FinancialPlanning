using FinancialPlanning.Data;
using FinancialPlanning.Presentation;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddCustomServices();
builder.Services.AddCustomRepository();
builder.Services.AddAutoMapperCustom();


// Configure the HTTP request pipeline.
builder.Services.AddDbContext<FinancialPlanningDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("FamilyBudgetStr"));
});
var app = builder.Build();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
