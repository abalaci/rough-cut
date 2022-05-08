WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddOrchardCms();

WebApplication app = builder.Build();

if (builder.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseOrchardCore();

app.Run();
