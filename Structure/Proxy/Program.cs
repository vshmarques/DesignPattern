using Microsoft.Extensions.Logging;
using Proxy.Proxy;

using var loggerFactory = LoggerFactory.Create(builder =>
{
    builder.AddConsole();
});
ILogger logger = loggerFactory.CreateLogger<Program>();

var result = new SignInProxy(logger).SignIn("test", "1234");

Console.WriteLine(result);