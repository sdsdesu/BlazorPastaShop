using Blazored.SessionStorage;
using BlazorPastaShop.Blazor.Client.Service;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;


var builder = WebAssemblyHostBuilder.CreateDefault(args);



builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://localhost:7051/") // poort van jouw API

});
builder.Services.AddScoped<KlantService>();
builder.Services.AddScoped<BestellingService>();

builder.Services.AddBlazoredSessionStorage();


await builder.Build().RunAsync();
