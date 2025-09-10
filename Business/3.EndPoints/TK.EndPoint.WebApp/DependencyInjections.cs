using TK.EndPoint.API;
using TK.EndPoint.WebApp.Components;

namespace TK.EndPoint.WebApp;

public static class DependencyInjections
{
    public static IServiceCollection AddEndPointApp(this IServiceCollection service,IConfiguration configuration)
    {
        service.AddRazorComponents().AddInteractiveServerComponents();
        service.AddEndPointApi();
        return service;
    }
    public static WebApplication UseEndPointApp(this WebApplication app)
    {
        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error", createScopeForErrors: true);
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseStaticFiles();
        app.UseAntiforgery();

        app.MapRazorComponents<App>()
            .AddInteractiveServerRenderMode();
        return app;
    }
}
