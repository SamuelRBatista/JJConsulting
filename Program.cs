using JJConsulting.Services;
var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddControllersWithViews();


// Configure HttpClient used to call the external API
builder.Services.AddHttpClient<IUserService, UserService>(client =>
{
    client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/");
    client.Timeout = TimeSpan.FromSeconds(30);
});


var app = builder.Build();


if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}


app.UseStaticFiles();
app.UseRouting();


app.MapControllerRoute(
name: "default",
pattern: "{controller=Users}/{action=Index}/{id?}");


app.Run();