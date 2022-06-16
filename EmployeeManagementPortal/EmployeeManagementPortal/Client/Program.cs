using EmployeeManagementPortal.Client;
using EmployeeManagementPortal.Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Blazored.LocalStorage;
using Blazored.SessionStorage;
using EmployeeManagementPortal.Client.HttpClients;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Basic Options
builder.Services.AddHttpClient();

// Named Option
builder.Services.AddHttpClient("NamedDemo", client =>
    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));

// Typed Option
builder.Services.AddHttpClient<TypedDemoHttpClient>(client =>
    client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress));

builder.Services.AddHttpClient("WeatherForecast", client =>
    client.BaseAddress = new Uri("https://localhost:7126"));

builder.Services.AddHttpClient("NodeDemo", client =>
    client.BaseAddress = new Uri("http://localhost:3000"));

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddBlazoredSessionStorage();
builder.Services.AddSingleton<StudentService>();

await builder.Build().RunAsync();
