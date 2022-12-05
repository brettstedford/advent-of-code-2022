using console.solutions;
using FluentAssertions;

namespace tests;

public class Day2Tests
{
    [Fact(Skip = "Part 1 test")]
    public void Rock_Win()
    {
        var testData = new[] { "C X" }; // ROCK (X) BEATS SCISSORS (C)
        Solutions.Day2(testData).Should().Be(7); // 6 + 1
    }

    [Fact(Skip = "Part 1 test")]
    public void Rock_Loss()
    {
        var testData = new[] { "B X" }; // ROCK (X) BEATEN BY PAPER (B)
        Solutions.Day2(testData).Should().Be(1); // 0 + 1
    }

    [Fact(Skip = "Part 1 test")]
    public void Rock_Draw()
    {
        var testData = new[] { "A X" }; // ROCK (X) DRAWS WITH SCISSORS (A)
        Solutions.Day2(testData).Should().Be(4); // 3 + 1
    }

    [Fact(Skip = "Part 1 test")]
    public void Paper_Win()
    {
        var testData = new[] { "A Y" }; // PAPER (Y) BEATS ROCK (A)
        Solutions.Day2(testData).Should().Be(8); // 6 + 2
    }

    [Fact(Skip = "Part 1 test")]
    public void Paper_Loss()
    {
        var testData = new[] { "C Y" }; // PAPER (Y) BEATEN BY SCISSORS (C)
        Solutions.Day2(testData).Should().Be(2); // 0 + 2
    }

    [Fact(Skip = "Part 1 test")]
    public void Paper_Draw()
    {
        var testData = new[] { "B Y" }; // PAPER (Y) DRAWS WITH PAPER (B)
        Solutions.Day2(testData).Should().Be(5); // 3 + 2
    }

    [Fact(Skip = "Part 1 test")]
    public void Scissors_Win()
    {
        var testData = new[] { "B Z" }; // SCISSORS (Z) BEATS PAPER (B)
        Solutions.Day2(testData).Should().Be(9); // 6 + 3
    }

    [Fact(Skip = "Part 1 test")]
    public void Scissors_Loss()
    {
        var testData = new[] { "A Z" }; // SCISSORS (Z) BEATEN BY ROCK (A)
        Solutions.Day2(testData).Should().Be(3); // 0 + 3
    }

    [Fact(Skip = "Part 1 test")]
    public void Scissors_Draw()
    {
        var testData = new[] { "C Z" }; // SCISSORS (Z) DRAWS WITH SCISSORS (C)
        Solutions.Day2(testData).Should().Be(6); // 3 + 3
    }

    [Fact(Skip = "Part 1 test")]
    public void TotalScore()
    {
        var testData = new[] { "A Y", "B X", "C Z" };
        Solutions.Day2(testData).Should().Be(15);
    }
    

    [Fact]
    public void Lose_Against_Rock()
    {
        var testData = new[] { "A X" }; // LOSE (X) WHEN OPPONENT PLAYS ROCK (A)
        Solutions.Day2(testData).Should().Be(3); // 0 + 3 (SCISSORS)
    }
    [Fact]
    public void Lose_Against_Paper()
    {
        var testData = new[] { "B X" }; // LOSE (X) WHEN OPPONENT PLAYS PAPER (B)
        Solutions.Day2(testData).Should().Be(1); // 0 + 1 (ROCK)
    }
    [Fact]
    public void Lose_Against_Scissors()
    {
        var testData = new[] { "C X" }; // LOSE (X) WHEN OPPONENT PLAYS SCISSORS (C)
        Solutions.Day2(testData).Should().Be(2); // 0 + 2 (PAPER)
    }

    [Fact]
    public void Draw_Against_Rock()
    {
        var testData = new[] { "A Y" }; // DRAW (Y) WHEN OPPONENT PLAYS ROCK (A)
        Solutions.Day2(testData).Should().Be(4); // 3 + 1 (ROCK)
    }
    [Fact]
    public void Draw_Against_Paper()
    {
        var testData = new[] { "B Y" }; // DRAW (Y) WHEN OPPONENT PLAYS PAPER (B)
        Solutions.Day2(testData).Should().Be(5); // 3 + 2 (PAPER)
    }
    [Fact]
    public void Draw_Against_Scissors()
    {
        var testData = new[] { "C Y" }; // DRAW (Y) WHEN OPPONENT PLAYS SCISSORS (C)
        Solutions.Day2(testData).Should().Be(6); // 3 + 3 (SCISSORS)
    }

    [Fact]
    public void Win_Against_Rock()
    {
        var testData = new[] { "A Z" }; // WIN (Z) WHEN OPPONENT PLAYS ROCK (A)
        Solutions.Day2(testData).Should().Be(8); // 6 + 2 (PAPER)
    }
    [Fact]
    public void Win_Against_Paper()
    {
        var testData = new[] { "B Z" }; // WIN (Z) WHEN OPPONENT PLAYS PAPER (B)
        Solutions.Day2(testData).Should().Be(9); // 6 + 3 (SCISSORS)
    }
    [Fact]
    public void Win_Against_Scissors()
    {
        var testData = new[] { "C Z" }; // WIN (Z) WHEN OPPONENT PLAYS SCISSORS (C)
        Solutions.Day2(testData).Should().Be(7); // 6 + 1
    }
    
    [Fact]
    public void TotalScore_Part2()
    {
        var testData = new[] { "A Y", "B X", "C Z" };
        Solutions.Day2(testData).Should().Be(12);
    }
}