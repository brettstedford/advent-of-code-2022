
var fileLines = File.ReadAllLines("input/day1-1.txt");

int highestCalories = 0;
List<int> currentElfCalories = new List<int>();
bool checkNextElf = false;

foreach (var line in fileLines)
{
    if (checkNextElf)
    {
        var elfCalories = currentElfCalories.Sum();

        if (elfCalories > highestCalories)
            highestCalories = elfCalories;

        currentElfCalories = new List<int>();
        
        checkNextElf = false;
    }
    
    if (string.IsNullOrEmpty(line))
    {
        checkNextElf = true;
        continue;
    }
    
    currentElfCalories.Add(int.Parse(line));
}

Console.WriteLine($"The highest calculated calories was: {highestCalories}");