using RoughCut.Web.Models.ContentParts;
using RoughCut.Web.Repositories;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
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

app.UseOrchardCore();

app.Run();
