namespace AdventOfCode.Content.Day02;

public static class Helper
{
    public const int ScoreWin = 6;
    public const int ScoreDraw = 3;
    public const int ScoreFail = 0;
    public const string OpponentValues = "ABC";
    public const string MyValues = "XYZ";

    public static string GetMyValue(string input) => input.Split(' ')[1];

    public static int GetMyIndex(string input) => MyValues.IndexOf(input.Split(' ')[1], StringComparison.Ordinal);

    public static int GetMyScore(string input) => GetMyIndex(input) + 1;

    public static int GetOpponentIndex(string input) =>
        OpponentValues.IndexOf(input.Split(' ')[0], StringComparison.Ordinal);

    public static int MoveLeft(int index) => index - 1 < 0 ? 2 : index - 1;

    public static int MoveRight(int index) => index + 1 == 3 ? 0 : index + 1;
}