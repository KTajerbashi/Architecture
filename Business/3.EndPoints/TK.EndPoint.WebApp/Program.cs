using TK.EndPoint.WebApp;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
builder.Services.AddEndPointApp(configuration);

var app = builder.Build();

app.UseEndPointApp();

app.Run();
