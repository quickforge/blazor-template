namespace Application.Data.Models;

public class Message
{
    public Guid Id { get; set; }

    public required string Greeting { get; set; }

    public required string Name { get; set; }
}