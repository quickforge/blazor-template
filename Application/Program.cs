using Application.Components;
using Application.Services;

using MudBlazor.Services;

namespace Application;

public class Program
{
    public static void AddServices(WebApplicationBuilder builder)
    {
        builder.Services.AddRazorComponents().AddInteractiveServerComponents();

        // Application services
        builder.Services.AddScoped<IHello, Hello>();
        builder.Services.AddMudServices();
    }

    public static void ConfigureApp(WebApplication app)
    {
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseAntiforgery();

        app.MapStaticAssets();
        app.MapRazorComponents<App>().AddInteractiveServerRenderMode();
    }

    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        AddServices(builder);

        var app = builder.Build();

        ConfigureApp(app);

        app.Run();
    }
}
