using Proxy.Interfaces;

namespace Proxy;

public class SignInReal : ISignIn
{
    public bool SignIn(string email, string password)
    {
        return email.Equals("teste@email.com") && password.Equals("1234");
    }
}
