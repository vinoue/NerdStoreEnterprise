using NSE.Carrinho.API;

var builder = WebApplication.CreateBuilder(args);

var startup = new Startup(builder.Environment);
startup.ConfigureServices(builder.Services);

var app = builder.Build();

startup.Configure(app, app.Environment);
app.Run();
