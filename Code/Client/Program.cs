using Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("FoodService", client =>
{
	client.BaseAddress = new Uri("https://localhost:5101/foodservice/");
});

builder.Services.AddHttpClient("DrinkService", client =>
{
	client.BaseAddress = new Uri("https://localhost:5101/drinkservice/");
});


await builder.Build().RunAsync();
