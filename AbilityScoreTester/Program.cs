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

        // the cast below also rounds down the double
        int added = addamount + (int)divided;
        
        // curly braces optional below
        if (added < minimum)
            score = minimum;
        else
            score = added;
    }
}

internal class Program
{
    /// <summary>
    /// Writes a prompt and reads an int value from the console
    /// </summary>
    /// <param name="lastUsedValue">default value</param>
    /// <param name="prompt">prints to console</param>
    /// <returns>int value read, or default if unable to parse</returns>
    static int ReadInt(int lastUsedValue, string prompt)
    {
        Console.Write(prompt + " [" + lastUsedValue + "]: ");
        string line = Console.ReadLine();
        if (int.TryParse(line, out int value))
        {
            Console.WriteLine("   using value " + value);
            return value;
        }
        else
        {
            Console.WriteLine("   using default value " + lastUsedValue);
            return lastUsedValue;
        }
    }
    /// <summary>
    /// Parses like ReadInt but for doubles
    /// </summary>
    static double ReadDouble(double lastUsedValue, string prompt)
    {
        Console.Write(prompt + " [" + lastUsedValue + "]: ");
        string line = Console.ReadLine();
        if (double.TryParse(line, out double value))
        {
            Console.WriteLine("   using value " + value);
            return value;
        }
        else
        {
            Console.WriteLine("   using default value " + lastUsedValue);
            return lastUsedValue;
        }
    }
    private static void Main(string[] args)
    {
        AbilityScoreCalculator calculator = new AbilityScoreCalculator();
        while (true)
        {
            calculator.rollresult = ReadInt(calculator.rollresult, "Starting 4d6 roll");
            calculator.divideby = ReadDouble(calculator.divideby, "Divide by");
            calculator.addamount = ReadInt(calculator.addamount, "Add amount");
            calculator.minimum = ReadInt(calculator.minimum, "Minimum");
            calculator.CalculateAbilityScore();
            Console.WriteLine("Calculated ability score: " + calculator.score);
            Console.WriteLine("Press Q to quit, any other key to continue");
            char keyChar = Console.ReadKey(true).KeyChar;
            if ((keyChar == 'Q') || (keyChar == 'q')) return;
            else Console.Write("\n");
        }
    }
}