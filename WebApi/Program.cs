var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();
app.MapOpenApi();

app.MapGet("/", () => "Hello World!");
app.MapGet("/hi", () => "hi there");

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.Run();
