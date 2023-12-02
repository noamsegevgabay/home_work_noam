var builder = WebApplication.CreateBuilder(args);


var app = builder.Build();

app.MapGet("/", () => "am israel hay! ! ! :)");

app.Run();
