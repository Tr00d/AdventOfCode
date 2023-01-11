namespace AdventOfCode.Content.Day02;

public class Game
{
    private readonly IEnumerable<string> list;
    private readonly StrategyGuide strategy;
    private readonly Func<string, int> evaluate;

    public Game(IEnumerable<string> list, Func<string, int> evaluate)
    {
        this.evaluate = evaluate;
        this.list = list;
    }

    public int EvaluateFollowingGuide() => this.list.Select(value => this.evaluate(value)).Sum();
}