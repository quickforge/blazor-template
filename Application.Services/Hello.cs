namespace Application.Services;

public interface IHello
{
    string SayHello();
}

public class Hello : IHello
{
    public string SayHello()
    {
        return "Hello, World!";
    }
}
