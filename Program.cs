using Microsoft.Extensions.Hosting;
using NetCord.Hosting.Gateway;

var builder = Host.CreateApplicationBuilder();

builder.Services
    .AddDiscordGateway();

var bot = builder.Build();

await bot.RunAsync();