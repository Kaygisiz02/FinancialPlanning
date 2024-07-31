using FinancialPlanning;
using FinancialPlanning.Presentation;
using Microsoft.EntityFrameworkCore;

//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddControllersWithViews();
//builder.Services.AddCustomServices();
//builder.Services.AddCustomRepository();
//builder.Services.AddAutoMapperCustom();

//builder.Services.AddDbContext<FinancialPlanningDbContext>(options =>
//{
//    options.UseSqlServer(builder.Configuration.GetConnectionString("FinancialPlanningStr"));
//});
//var app = builder.Build();

//app.MapControllerRoute
//    ("default", pattern: 
//     "{Controller=Home}/{action=Index}/{id?}"
//     );//2
//app.UseStaticFiles();//3
////? Optinal
//app.Run();


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddCustomServices();
builder.Services.AddCustomRepository();
builder.Services.AddAutoMapperCustom();

builder.Services.AddDbContext<FinancialPlanningDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("FinancialPlanningStr"));
});
var app = builder.Build();

app.MapControllerRoute("default", pattern: "{Controller=Home}/{action=Index}/{id?}");//2
app.UseStaticFiles();//3
//? Optinal
app.Run();
