using System.Collections.Generic;
using System.IO;
using AdventOfCode.Content.Day02;
using FluentAssertions;
using Xunit;

namespace AdventOfCode.Content.Tests.Day02;

public class GameTest
{
    [Fact]
    public void EvaluateFollowingGuide_ShouldReturnScore_GivenExampleScenario()
    {
        var inputs = new List<string>
        {
            "A Y", "B X", "C Z",
        };
        var game = new Game(inputs, new StrategyGuide().Evaluate);
        var result = game.EvaluateFollowingGuide();
        result.Should().Be(15);
    }

    [Fact]
    public void EvaluateFollowingGuide_ShouldReturnScore_GivenInputFile()
    {
        var game = new Game(File.ReadAllLines("Day02/PuzzleInput.txt"), new StrategyGuide().Evaluate);
        var result = game.EvaluateFollowingGuide();
        result.Should().Be(10816);
    }

    [Fact]
    public void EvaluateFollowingGuide_ShouldReturnScore_GivenExampleScenarioWithUpdatedGuide()
    {
        var inputs = new List<string>
        {
            "A Y", "B X", "C Z",
        };
        var game = new Game(inputs, new StrategyGuideV2().Evaluate);
        var result = game.EvaluateFollowingGuide();
        result.Should().Be(12);
    }

    [Fact]
    public void EvaluateFollowingGuide_ShouldReturnScore_GivenInputFileWithUpdatedGuide()
    {
        var game = new Game(File.ReadAllLines("Day02/PuzzleInput.txt"), new StrategyGuideV2().Evaluate);
        var result = game.EvaluateFollowingGuide();
        result.Should().Be(11657);
    }
}