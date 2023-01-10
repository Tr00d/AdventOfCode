namespace AdventOfCode.Content.Day01;

public class Items
{
    private readonly IEnumerable<string> list;

    public Items(IEnumerable<string> list)
    {
        this.list = list;
    }

    public int FindMaxCalories() => this.CalculateCalories().MaxBy(value => value);

    public int FindMaxCaloriesByTopThree() => this.CalculateCalories().OrderByDescending(value => value).Take(3).Sum();

    private IEnumerable<int> CalculateCalories()
    {
        var elfs = new List<int>();
        int elfIndex = default;
        foreach (var calories in this.list)
        {
            if (string.IsNullOrEmpty(calories))
            {
                elfIndex++;
                continue;
            }

            if (elfs.Count <= elfIndex)
            {
                elfs.Add(default);
            }

            elfs[elfIndex] += int.Parse(calories);
        }

        return elfs;
    }
}