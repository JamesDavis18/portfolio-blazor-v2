using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using portfolio_blazor_v2.Client;
using portfolio_blazor_v2;

public class Program
{
    public static async Task Main(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
        builder.RootComponents.Add<App>("#app"); // Ensure 'App' is defined in the correct namespace
        builder.Services.AddMudServices();
        app.UseStatusCodePAgeWithReExecute("/Error/{0}");
        // Add other services as needed
        // builder.Services.AddScoped<YourService>();
        await builder.Build().RunAsync();
    }
}
