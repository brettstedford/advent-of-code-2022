using console;

var fileLines = File.ReadAllLines("input/day1-1.txt");

Console.WriteLine($"The sum of the highest three calculated calories was: {Solutions.Day1(fileLines)}");