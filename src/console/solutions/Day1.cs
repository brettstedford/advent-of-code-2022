namespace console.solutions;

public static partial class Solutions
{
    public static int Day1(string[] input)
    {
        var highestThreeCalories = new int[3];
        var currentElfCalories = new List<int>();
        var checkNextElf = false;

        foreach (var line in input)
        {
            if (checkNextElf)
            {
                var elfCalories = currentElfCalories.Sum();
                currentElfCalories = new List<int>();
                checkNextElf = false;

                var length = highestThreeCalories.Length;

                if (length < 3)
                {
                    highestThreeCalories[length - 1] = elfCalories;
                    continue;
                }

                var lowest = highestThreeCalories.Min();

                if (elfCalories > lowest)
                {
                    for (var i = 0; i < 3; i++)
                    {
                        if (highestThreeCalories[i] == lowest)
                        {
                            highestThreeCalories[i] = elfCalories;
                            break;
                        }
                    }
                }
            }

            if (string.IsNullOrEmpty(line))
            {
                checkNextElf = true;
                continue;
            }

            currentElfCalories.Add(int.Parse(line));
        }

        return highestThreeCalories.Sum();
    }
}