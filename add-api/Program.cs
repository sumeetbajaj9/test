var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/add", (int a, int b) => Results.Json(new { result = a + b }));

app.Run();
