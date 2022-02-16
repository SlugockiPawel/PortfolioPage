using Microsoft.Extensions.Configuration;
using Portfolio.Models;
using Portfolio.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.Configure<EmailSettings>(builder.Configuration.GetSection("EmailSettings"));
builder.Services.AddScoped<IPortfolioEmailSender, EmailService>();


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

/*
   TODO create Project ViewModel
    TODO create ProjectSeeder (service or seed at app startup?)
    TODO create img encrypt-decrypt service
    TODO populate ProjectList to partial views and populate cards
    TODO based on card clicked- create dynamically modals


    *TODO add backdrop modal after message is sent in Contact Me form (close will redirect to Index Page)
    *
 
 */
