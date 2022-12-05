namespace console.solutions;

public static partial class Solutions
{
    private enum Hands
    {
        Rock,
        Paper,
        Scissors
    }

    private enum Outcome
    {
        Lose,
        Draw,
        Win
    }

    private static readonly Dictionary<char, Hands> OpponentMap = new()
    {
        { 'A', Hands.Rock },
        { 'B', Hands.Paper },
        { 'C', Hands.Scissors }
    };

    private static readonly Dictionary<Hands, int> HandScoreMap = new()
    {
        { Hands.Rock, 1 },
        { Hands.Paper, 2 },
        { Hands.Scissors, 3 }
    };

    private static readonly Dictionary<Outcome, int> OutcomeScoreMap = new()
    {
        { Outcome.Lose, 0 },
        { Outcome.Draw, 3 },
        { Outcome.Win, 6 }
    };

    private static readonly Dictionary<char, Outcome> MyOutcomeMap = new()
    {
        { 'X', Outcome.Lose },
        { 'Y', Outcome.Draw },
        { 'Z', Outcome.Win }
    };

    private const int DrawScore = 3;

    public static int Day2(string[] fileLines)
    {
        var score = 0;

        foreach (var line in fileLines)
        {
            var parts = line.Split(" ");

            var opponentHand = OpponentMap[parts[0].ToCharArray()[0]];
            var outcome = MyOutcomeMap[parts[1].ToCharArray()[0]];

            if (outcome == Outcome.Draw)
            {
                score += DrawScore + HandScoreMap[opponentHand];
                continue;
            }

            var handScore = opponentHand switch
            {
                Hands.Rock => outcome == Outcome.Win ? HandScoreMap[Hands.Paper] : HandScoreMap[Hands.Scissors],
                Hands.Paper => outcome == Outcome.Win ? HandScoreMap[Hands.Scissors] : HandScoreMap[Hands.Rock],
                Hands.Scissors => outcome == Outcome.Win ? HandScoreMap[Hands.Rock] : HandScoreMap[Hands.Paper],
                _ => 0
            };

            score += OutcomeScoreMap[outcome] + handScore;
        }

        return score;
    }
}