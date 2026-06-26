using MudBlazor.Services;
using Microsoft.EntityFrameworkCore;
using FullBrain.Components;
using FullBrain.Data;


var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddMudServices();
builder.Services.AddControllers();
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql (builder.Configuration.GetConnectionString("DefaultConnection")));


// Add configuration EF Core
builder.Services.AddDbContext<DbContext>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnectionString")));

// Add services to the container
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(FullBrain.Client._Imports).Assembly);

app.Run();
