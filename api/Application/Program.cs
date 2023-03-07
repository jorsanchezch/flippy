using FluentValidation;
using Application.Requests.Sample;
using Application.Validators.Sample;
using Domain.Repositories.Sample;
using Infrastructure.Repositories.Sample;
using Domain.Repositories;
using Infrastructure.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Application.Services.Sample;

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

builder.Services.AddTransient<IValidator<SoundRequest>, CreateSoundValidator>();
builder.Services.AddTransient<IValidator<UpdateSoundRequest>, UpdateSoundValidator>();
builder.Services.AddTransient<ISoundRepository, SoundRepository>();

builder.Services.AddTransient<IFileRepository, SoundFileRepository>();

builder.Services.AddTransient<ISoundService, SoundService>();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "Cors",
                      policy =>
                      {
                          policy.WithOrigins("http://localhost:5000", "https://localhost:5000");
                      });
});

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
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.UseCors("Cors");

app.MapRazorPages();

app.Run();
