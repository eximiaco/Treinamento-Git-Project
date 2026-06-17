var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

// Endpoint principal do treinamento Git da Tramontina.
// A simplicidade é proposital: o foco da Trilha 1 é o fluxo Git, não o código.
app.MapGet("/hello", () => new
{
    message = "Hello, Tramontina!",
    project = "Treinamento-Tramontina-Git",
    track   = "Trilha 1 — Git: do zero ao fluxo diário"
});

app.Run();
