using System.Collections.Generic;
using System.IO;
using AdventOfCode.Content.Day01;
using FluentAssertions;
using Xunit;

namespace AdventOfCode.Content.Tests.Day01;

public class ItemsTest
{
    [Fact]
    public void FindMaxCalories_ShouldReturnCountOfMaxCalories_GivenExampleScenario()
    {
        var items = new Items(GetExampleInput());
        var maxCalories = items.FindMaxCalories();
        maxCalories.Should().Be(24000);
    }

    [Fact]
    public void FindMaxCaloriesByTopThree_ShouldReturnCountOfMaxCalories_GivenExampleScenario()
    {
        var items = new Items(GetExampleInput());
        var maxCalories = items.FindMaxCaloriesByTopThree();
        maxCalories.Should().Be(45000);
    }

    [Fact]
    public void FindMaxCalories_ShouldReturnCountOfMaxCalories_GivenInputFile()
    {
        var items = new Items(File.ReadAllLines("Day01/PuzzleInput.txt"));
        var maxCalories = items.FindMaxCalories();
        maxCalories.Should().Be(70374);
    }

    [Fact]
    public void FindMaxCaloriesByTopThree_ShouldReturnCountOfMaxCalories_GivenInputFile()
    {
        var items = new Items(File.ReadAllLines("Day01/PuzzleInput.txt"));
        var maxCalories = items.FindMaxCaloriesByTopThree();
        maxCalories.Should().Be(204610);
    }

    private static List<string> GetExampleInput() =>
        new()
        {
            "1000",
            "2000",
            "3000",
            "",
            "4000",
            "",
            "5000",
            "6000",
            "",
            "7000",
            "8000",
            "9000",
            "",
            "10000",
        };
}