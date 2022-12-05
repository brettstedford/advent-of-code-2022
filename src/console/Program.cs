using console.solutions;

var fileLines = File.ReadAllLines("input/day1.txt");

Console.WriteLine($"The sum of the highest three calculated calories was: {Solutions.Day1(fileLines)}");

fileLines = File.ReadAllLines("input/day2.txt");

Console.WriteLine($"Your total score playing would be: {Solutions.Day2(fileLines)}");