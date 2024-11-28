using Application.Console;

using Spectre.Console;

var runnerName = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("Choose a runner:")
        .AddChoices(Enum.GetNames<RunnerEnum>())
);

AnsiConsole.MarkupLine($"You selected [blue]{runnerName}[/].");

var runner = RunnerResolver.Resolve(Enum.Parse<RunnerEnum>(runnerName));

runner.Run();