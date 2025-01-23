using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Syncfusion.Blazor;

namespace BlazorTestPdfViewerNextGen.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.Services.AddSyncfusionBlazor();
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("todo");
            // If you are using a WebAssembly application, include the following line in the Program.cs file
            builder.Services.AddMemoryCache();
            await builder.Build().RunAsync();
        }
    }
}
