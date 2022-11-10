using Microsoft.Extensions.Configuration;
using Portfolio.Services;
using PortfolioPage.Clients;
using PortfolioPage.Models;
using PortfolioPage.Services;
using PortfolioPage.ViewModels;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));
builder.Services.Configure<BlogApiSettings>(builder.Configuration.GetSection("BlogApiSettings"));
builder.Services.AddScoped<IPortfolioEmailSender, EmailService>();
builder.Services.AddScoped<IImageService, ImageService>();

builder.Services.AddSingleton<IBlogClient, BlogClient>();
builder.Services.AddHttpClient<IBlogClient, BlogClient>();

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

