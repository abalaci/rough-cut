using OrchardCore.Logging;
using RoughCut.Web.Models.ContentParts;
using RoughCut.Web.Repositories;
using Serilog;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();

builder.Services.AddSerilog((services, loggerConfiguration) => loggerConfiguration
    .ReadFrom.Configuration(builder.Configuration)
    .ReadFrom.Services(services)
    .Enrich.FromLogContext());

builder.Services.AddOrchardCms();
builder.Services.AddContentParts();
builder.Services.AddRepositories();

WebApplication app = builder.Build();

if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseOrchardCore(appBuilder => appBuilder.UseSerilogTenantNameLogging());

app.Run();
