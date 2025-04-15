var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapGet("/nossa-historia", async context =>
{
    var env = context.RequestServices.GetRequiredService<IWebHostEnvironment>();
    var filePath = Path.Combine(env.WebRootPath, "nossa-historia.html");
    await context.Response.SendFileAsync(filePath);
});

app.MapGet("/carreiras", async context =>
{
    var env = context.RequestServices.GetRequiredService<IWebHostEnvironment>();
    var filePath = Path.Combine(env.WebRootPath, "carreiras.html");
    await context.Response.SendFileAsync(filePath);
});

app.MapGet("/contato", async context =>
{
    var env = context.RequestServices.GetRequiredService<IWebHostEnvironment>();
    var filePath = Path.Combine(env.WebRootPath, "contato.html");
    await context.Response.SendFileAsync(filePath);
});

app.MapGet("/produtos", async context =>
{
    var env = context.RequestServices.GetRequiredService<IWebHostEnvironment>();
    var filePath = Path.Combine(env.WebRootPath, "produtos", "index.html");
    await context.Response.SendFileAsync(filePath);
});

app.MapGet("/produtos/esmaltes", async context =>
{
    var env = context.RequestServices.GetRequiredService<IWebHostEnvironment>();
    var filePath = Path.Combine(env.WebRootPath, "produtos", "esmaltes.html");
    await context.Response.SendFileAsync(filePath);
});

app.MapGet("/produtos/ferramentas", async context =>
{
    var env = context.RequestServices.GetRequiredService<IWebHostEnvironment>();
    var filePath = Path.Combine(env.WebRootPath, "produtos", "ferramentas.html");
    await context.Response.SendFileAsync(filePath);
});

app.MapGet("/produtos/janelas", async context =>
{
    var env = context.RequestServices.GetRequiredService<IWebHostEnvironment>();
    var filePath = Path.Combine(env.WebRootPath, "produtos", "janelas.html");
    await context.Response.SendFileAsync(filePath);
});

app.MapGet("/produtos/materiais-eletricos", async context =>
{
    var env = context.RequestServices.GetRequiredService<IWebHostEnvironment>();
    var filePath = Path.Combine(env.WebRootPath, "produtos", "materiais-eletricos.html");
    await context.Response.SendFileAsync(filePath);
});

app.MapGet("/produtos/materiais-hidraulicos", async context =>
{
    var env = context.RequestServices.GetRequiredService<IWebHostEnvironment>();
    var filePath = Path.Combine(env.WebRootPath, "produtos", "materiais-hidraulicos.html");
    await context.Response.SendFileAsync(filePath);
});

app.MapGet("/produtos/metais", async context =>
{
    var env = context.RequestServices.GetRequiredService<IWebHostEnvironment>();
    var filePath = Path.Combine(env.WebRootPath, "produtos", "metais.html");
    await context.Response.SendFileAsync(filePath);
});

app.MapGet("/produtos/para-sua-construcao", async context =>
{
    var env = context.RequestServices.GetRequiredService<IWebHostEnvironment>();
    var filePath = Path.Combine(env.WebRootPath, "produtos", "para-sua-construcao.html");
    await context.Response.SendFileAsync(filePath);
});

app.MapGet("/produtos/pisos-e-revestimentos", async context =>
{
    var env = context.RequestServices.GetRequiredService<IWebHostEnvironment>();
    var filePath = Path.Combine(env.WebRootPath, "produtos", "pisos-e-revestimentos.html");
    await context.Response.SendFileAsync(filePath);
});

app.MapGet("/produtos/portas", async context =>
{
    var env = context.RequestServices.GetRequiredService<IWebHostEnvironment>();
    var filePath = Path.Combine(env.WebRootPath, "produtos", "portas.html");
    await context.Response.SendFileAsync(filePath);
});
app.MapGet("/produtos/tintas", async context =>
{
    var env = context.RequestServices.GetRequiredService<IWebHostEnvironment>();
    var filePath = Path.Combine(env.WebRootPath, "produtos", "tintas.html");
    await context.Response.SendFileAsync(filePath);
});
app.MapGet("/produtos/vernizes", async context =>
{
    var env = context.RequestServices.GetRequiredService<IWebHostEnvironment>();
    var filePath = Path.Combine(env.WebRootPath, "produtos", "vernizes.html");
    await context.Response.SendFileAsync(filePath);
});

app.Run();