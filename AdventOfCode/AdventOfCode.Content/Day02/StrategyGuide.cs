namespace AdventOfCode.Content.Day02;

public class StrategyGuide
{
    public int Evaluate(string input) => GetGameScore(input) + Helper.GetMyScore(input);

    private static int GetGameScore(string input) =>
        IsWinner(input) ? Helper.ScoreWin :
        IsDraw(input) ? Helper.ScoreDraw : Helper.ScoreFail;

    private static bool IsDraw(string input) => Helper.GetMyIndex(input) == Helper.GetOpponentIndex(input);

    private static bool IsWinner(string input) =>
        Helper.MoveLeft(Helper.GetMyIndex(input)) == Helper.GetOpponentIndex(input);
}