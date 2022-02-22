var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.MapGet("/hello/{name}", (string name) => $"Hello {name}");
app.MapGet("/person", () => new Person("Elon", "Musk"));
app.MapGet("/todos", () => new { TodoItem = "Something To Do", Complete = false, ETA = "Never" });
app.MapGet("/dobad", () => int.Parse("This is not an int."));
app.MapPost("/post", () => "This is a POST.");

app.MapRazorPages();
app.Run();

public record Person (string FirstName, string LastName);
