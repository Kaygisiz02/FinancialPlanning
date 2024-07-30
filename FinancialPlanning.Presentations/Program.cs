using FinancialPlanning;
using FinancialPlanning.Presentation;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var app = builder.Build();
// Add services to the container.
builder.Services.AddCustomServices();
builder.Services.AddCustomRepository();
builder.Services.AddAutoMapperCustom();

// Configure the HTTP request pipeline.
builder.Services.AddDbContext<FinancialPlanningDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("FinancialPlanningStr"));
});
app.UseStaticFiles();//3
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
