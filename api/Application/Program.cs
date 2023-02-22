using FluentValidation;
using Application.Requests.Sample;
using Application.Validators.Sample;
using Domain.Repositories.Sample;
using Infrastructure.Repositories.Sample;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var conn = builder.Configuration
    .GetSection("Connections:MySql")
    .GetValue<string>("Local");

builder.Services.AddRazorPages();

// Add validators and requests to the container
builder.Services.AddDbContext<AppDbContext>(x => x.UseMySql(conn, ServerVersion.AutoDetect(conn)));



builder.Services.AddTransient<IValidator<GenreRequest>, CreateGenreValidator>();
builder.Services.AddTransient<IValidator<UpdateGenreRequest>, UpdateGenreValidator>();
builder.Services.AddTransient<IGenreRepository, GenreRepository>();

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
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
