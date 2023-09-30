var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHealthChecks();

var app = builder.Build();

app.MapHealthChecks("/health");

app.MapGet("/", () => {
    return Results.Ok(new { message = "Here is a worker"});
});

app.Run();
