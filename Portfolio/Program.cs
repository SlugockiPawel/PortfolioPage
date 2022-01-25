var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

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
    TODO how to transform navbar from top to sidebar
    TODO make social icon background a circle and add it as bootstrap class
    TODO how to make <ul> wrap on narrow screen one item by one

 * TODO add About Me View
 * TODO add Contact View
 * TODO add Portfolio View
 * TODO add The Blog project ref
 * TODO add email service to contact form
 *
 
 */
