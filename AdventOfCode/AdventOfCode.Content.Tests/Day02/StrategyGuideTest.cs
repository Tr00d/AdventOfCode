using AdventOfCode.Content.Day02;
using FluentAssertions;
using Xunit;

namespace AdventOfCode.Content.Tests.Day02;

public class StrategyGuideTest
{
    [Theory]
    [InlineData("A Y", 8)]
    [InlineData("B Z", 9)]
    [InlineData("C X", 7)]
    public void Evaluate_ShouldReturnExpectedScore_GivenWin(string input, int score) =>
        new StrategyGuide().Evaluate(input).Should().Be(score);

    [Theory]
    [InlineData("A X", 4)]
    [InlineData("B Y", 5)]
    [InlineData("C Z", 6)]
    public void Evaluate_ShouldReturnExpectedScore_GivenDraw(string input, int score) =>
        new StrategyGuide().Evaluate(input).Should().Be(score);

    [Theory]
    [InlineData("B X", 1)]
    [InlineData("C Y", 2)]
    [InlineData("A Z", 3)]
    public void Evaluate_ShouldReturnExpectedScore_GivenLoss(string input, int score) =>
        new StrategyGuide().Evaluate(input).Should().Be(score);
}