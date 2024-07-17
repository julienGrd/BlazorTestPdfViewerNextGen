using BlazorTestPdfViewerNextGen.Client.Pages;
using BlazorTestPdfViewerNextGen.Components;
using Syncfusion.Blazor;

namespace BlazorTestPdfViewerNextGen
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorComponents()
                .AddInteractiveServerComponents()
                .AddInteractiveWebAssemblyComponents();


            builder.Services.AddMemoryCache();

            builder.Services.AddServerSideBlazor().AddHubOptions(o => { o.MaximumReceiveMessageSize = 102400000; });

            //Add Syncfusion Blazor service to the container
            builder.Services.AddSyncfusionBlazor();

            var app = builder.Build();


            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("todo");
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseWebAssemblyDebugging();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();
            app.UseAntiforgery();

            app.MapRazorComponents<App>()
                .AddInteractiveWebAssemblyRenderMode()
                .AddInteractiveServerRenderMode()
                .AddAdditionalAssemblies(typeof(Client._Imports).Assembly);


            app.Run();
        }
    }
}
