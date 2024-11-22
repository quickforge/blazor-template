namespace Application.Services;

using Application.Shared.Enums;

public interface IHello
{
    string SayHello();
}

public class Hello : IHello
{
    public string SayHello()
    {
        return $"Hello, {Foo.Bar}!";
    }
}
