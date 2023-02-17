﻿/// <summary>
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
        int added = addamount += (int)divided;
        
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
        // write prompt followed by [default value]:
        // Read the line from the input and use int.TryParse to attempt to parse it
        // If it can be parsed, write "using value" + value to console
        // Otherwise write "using default value" + lastUsedValue to the console
    }
    /// <summary>
    /// Parses like ReadInt but for doubles
    /// </summary>
    static double ReadDouble(double lastUsedValue, string prompt)
    {
        
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
        }
    }
}