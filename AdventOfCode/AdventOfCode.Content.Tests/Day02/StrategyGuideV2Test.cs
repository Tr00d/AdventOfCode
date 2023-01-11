using AdventOfCode.Content.Day02;
using FluentAssertions;
using Xunit;

namespace AdventOfCode.Content.Tests.Day02;

public class StrategyGuideV2Test
{
    [Theory]
    [InlineData("A Z", 8)]
    [InlineData("B Z", 9)]
    [InlineData("C Z", 7)]
    public void EvaluateV2_ShouldReturnExpectedScore_GivenWin(string input, int score) =>
        new StrategyGuideV2().Evaluate(input).Should().Be(score);

    [Theory]
    [InlineData("A Y", 4)]
    [InlineData("B Y", 5)]
    [InlineData("C Y", 6)]
    public void Evaluate_ShouldReturnExpectedScore_GivenDraw(string input, int score) =>
        new StrategyGuideV2().Evaluate(input).Should().Be(score);

    [Theory]
    [InlineData("B X", 1)]
    [InlineData("C X", 2)]
    [InlineData("A X", 3)]
    public void Evaluate_ShouldReturnExpectedScore_GivenLoss(string input, int score) =>
        new StrategyGuideV2().Evaluate(input).Should().Be(score);
}