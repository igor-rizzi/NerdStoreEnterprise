using NSE.WebApp.MVC.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddWebAppConfiguration();
builder.Services.AddIdentityConfiguration();
builder.Services.RegisterServices();

var app = builder.Build();

app.UseWebAppConfiguration(app.Environment);

app.Run();
