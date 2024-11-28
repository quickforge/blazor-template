using Application.Console.Runners.CrudGenerator;

namespace Application.Console;

public class RunnerResolver
{
    public static IRunner Resolve(RunnerEnum runner)
    {
        return runner switch
        {
            RunnerEnum.CrudGenerator => new CrudGenerator(),
            _ => throw new Exception($"Runner '{runner}' not found")
        };
    }
}