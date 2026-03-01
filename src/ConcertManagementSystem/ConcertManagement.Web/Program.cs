using ConcertManagement.Infrastructure; 
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<ConcertContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("ConcertContext"),
        sqlOptions => sqlOptions.MigrationsAssembly(Assembly.GetExecutingAssembly().GetName().Name)
    ));


builder.Services.AddRazorPages();

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();