using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using MyPortfolio;
using MyPortfolio.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<IPortfolioService, PortfolioService>();
builder.Services.AddScoped<IJobsService, JobsService>();
builder.Services.AddScoped<ILifeService, LifeService>();
builder.Services.AddScoped<IStudiesService, StudiesService>();

builder.Services.AddMudServices();

await builder.Build().RunAsync();
