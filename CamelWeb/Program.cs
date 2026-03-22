using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using CamelWeb;
using Blazored.LocalStorage; // Додано цей рядок, щоб прибрати помилку

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// Тепер ця лінія не буде підкреслена червоним
builder.Services.AddBlazoredLocalStorage();

await builder.Build().RunAsync();