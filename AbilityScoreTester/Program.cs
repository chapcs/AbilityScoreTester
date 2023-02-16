/// <summary>
/// This class follows the ability score formula of owen's game
/// </summary>
class AbilityScoreCalculator
{
    public int rollresult = 14;
    public double divideby = 1.75;
    public int addamount = 2;
    public int minimum = 3;
    public int score;

    public void CalculateAbilityScore()
    {
        double divided = rollresult / divideby;
        int added = addamount += divided; // will result in error, need to cast
        
        // curly braces optional below
        if (added < minimum)
            score = minimum;
        else
            score = added;
    }
}

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}