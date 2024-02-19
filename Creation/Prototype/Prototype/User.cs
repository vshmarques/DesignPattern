namespace Prototype;

internal class User : UserBase
{
    private string _name;
    private string _email;

    public User(string name, string email)
    {
        _name = name;
        _email = email;
    }

    public override UserBase Clone()
    {
        return MemberwiseClone() as User;
    }

    public override string ToString()
    {
        return $"Name: {_name}, Email: {_email}";
    }
}
