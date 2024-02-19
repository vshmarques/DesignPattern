using Microsoft.Extensions.Logging;
using Proxy.Interfaces;

namespace Proxy.Proxy;

public class SignInProxy : ISignIn
{
    private readonly ILogger _logger;

    public SignInProxy(ILogger logger) => _logger = logger;
    

    public bool SignIn(string email, string password)
    {
        _logger.LogInformation($"User {email} attemping to signin");

        return new SignInReal().SignIn(email, password);
    }
}
