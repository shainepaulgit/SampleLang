var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
if (app.Environment.IsDevelopment())
    app.UseDeveloperExceptionPage();
app.UseStaticFiles();
//app.MapGet("/", () => "Hello World!");
app.UseEndpoints(e =>
{
    e.MapDefaultControllerRoute();
});
app.UseRouting();
app.Run();
