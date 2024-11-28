using Spectre.Console;

namespace Application.Console.Runners.CrudGenerator;

public class CrudGenerator : IRunner
{
    public void Run()
    {
        AnsiConsole.WriteLine("Running CrudGenerator...");
    }
}