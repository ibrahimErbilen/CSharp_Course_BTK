#region main

ScoringAlgorithm algorithm;
Console.WriteLine($"Men");
algorithm = new MenScoringAlgorithm();
Console.WriteLine($"{algorithm.GenerateScore(10, new TimeSpan(0, 2, 34))}");

Console.WriteLine($"Women");
algorithm = new WomenScoringAlgorithm();
Console.WriteLine($"{algorithm.GenerateScore(10, new TimeSpan(0, 2, 34))}");

Console.WriteLine($"Children");
algorithm = new ChildrenScoringAlgorithm();
Console.WriteLine($"{algorithm.GenerateScore(10, new TimeSpan(0, 2, 34))}");

#endregion


abstract class ScoringAlgorithm
{
    public int GenerateScore(int hits, TimeSpan time)
    {
        int score = CalculateBaseScore(hits);
        int reduction = CalculateReduction(time);

        return CalculateOverallScore(score, reduction);
    }

    protected abstract int CalculateOverallScore(int score, int reduction);
    protected abstract int CalculateReduction(TimeSpan time);
    protected abstract int CalculateBaseScore(int hits);
}

class MenScoringAlgorithm : ScoringAlgorithm
{
    protected override int CalculateBaseScore(int hits) => hits * 100;

    protected override int CalculateOverallScore(int score, int reduction) => score - reduction;

    protected override int CalculateReduction(TimeSpan time) => (int)time.TotalSeconds / 5;
}

class WomenScoringAlgorithm : ScoringAlgorithm
{
    protected override int CalculateBaseScore(int hits) => hits * 100;

    protected override int CalculateOverallScore(int score, int reduction) => score - reduction;

    protected override int CalculateReduction(TimeSpan time) => (int)time.TotalSeconds / 3;
}

class ChildrenScoringAlgorithm : ScoringAlgorithm
{
    protected override int CalculateBaseScore(int hits) => hits * 80;

    protected override int CalculateOverallScore(int score, int reduction) => score - reduction;

    protected override int CalculateReduction(TimeSpan time) => (int)time.TotalSeconds / 2;
}
