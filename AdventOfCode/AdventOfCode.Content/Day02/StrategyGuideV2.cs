namespace AdventOfCode.Content.Day02;

public class StrategyGuideV2
{
    public int Evaluate(string input)
    {
        var index = Helper.GetOpponentIndex(input);
        return Helper.GetMyValue(input) switch
        {
            "Z" => Helper.ScoreWin + Helper.MoveRight(index) + 1,
            "Y" => Helper.ScoreDraw + index + 1,
            _ => Helper.ScoreFail + Helper.MoveLeft(index) + 1,
        };
    }
}