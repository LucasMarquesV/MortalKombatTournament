using Business.Services;
using Data.Config;
using Data.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddEntityFrameworkSqlServer().AddDbContext<ContextoBase>
    (x => x.UseSqlServer("Server = CTS1A519661\\SQLEXPRESS; Database = DB_Lutadores;  User Id = sa; Password = Ab1234"));
builder.Services.AddScoped<ILutadorRepository, LutadorRepository>();
builder.Services.AddScoped<ILutadorServices, LutadorServices>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
