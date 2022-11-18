using DesignPatterns;
using Spectre.Console;

var pattern = AnsiConsole.Prompt(
    new SelectionPrompt<string>()
        .Title("Select a [green]Design Pattern[/]")
        .PageSize(10)
        .MoreChoicesText("[grey](Move up and down to reveal more design patterns)[/]")
        .AddChoices(new[] {
            "Strategy Pattern", "Composite Pattern"
        }));

switch (pattern)
{
    case "Strategy Pattern":
        Examples.StrategyPattern();
        break;
    case "Composite Pattern":
        Examples.CompositePattern();
        break;
}
