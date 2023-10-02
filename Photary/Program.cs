using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Photary;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
#if DEBUG
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5236/") });
#else
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://www.sato-home.mydns.jp:8443/api/v1/") });
#endif

await builder.Build().RunAsync();

