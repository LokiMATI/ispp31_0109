using ApiServices.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

HttpClient httpClient = new();
httpClient.BaseAddress = new Uri("http://localhost:5177");

builder.Services.AddSingleton(httpClient);
builder.Services.AddScoped<GamesService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
