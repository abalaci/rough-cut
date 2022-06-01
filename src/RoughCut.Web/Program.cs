using OrchardCore.Logging;
using RoughCut.Web.Models.ContentParts;
using RoughCut.Web.Repositories;
using Serilog;

WebApplicationBuilder webAppBuilder = WebApplication.CreateBuilder(args);

webAppBuilder.Host
    .ConfigureLogging(b => b.ClearProviders())
    .UseSerilog((hostingContext, loggerConfiguration) =>
    {
        loggerConfiguration.ReadFrom.Configuration(hostingContext.Configuration).Enrich.FromLogContext();
    });

webAppBuilder.Services.AddOrchardCms();
webAppBuilder.Services.AddContentParts();
webAppBuilder.Services.AddRepositories();

WebApplication app = webAppBuilder.Build();

if (webAppBuilder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseOrchardCore(appBuilder => appBuilder.UseSerilogTenantNameLogging());

app.Run();
