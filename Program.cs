using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Berheci_Gabriela_Lab2.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<Berheci_Gabriela_Lab2Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Berheci_Gabriela_Lab2Context") ?? throw new InvalidOperationException("Connection string 'Berheci_Gabriela_Lab2Context' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
