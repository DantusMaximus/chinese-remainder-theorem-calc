using KinesiskaRestsatsen;
using System.IO;
using System.Collections.Generic;
using System;

class Read
{
    public static ICongruenceSystem CoungruenceSystem()
    {
        string userInput;
        do
        {
            Print.PromptCongSysSpec();
            userInput = System.Console.ReadLine();
        }
        while (!Read.ValidBit(userInput));
        switch (userInput)
        {
            case "0": return new InputCongurenceSystem(ArgumentsFromFile());
            case "1": return new GeneratedCongruenceSystem(GenerationArguments());
            default: throw new NotImplementedException();
        }
    }

    public static (int, int) GenerationArguments()
    {
        string maxVal, congCount;
        do
        {
            Print.PromptGenSpec();
            maxVal = System.Console.ReadLine().Split("\n")[0];
            congCount = System.Console.ReadLine();
        }
        while (!Read.ValidInteger(maxVal, 2) || !Read.ValidInteger(congCount, 1));
        return (int.Parse(maxVal), int.Parse(congCount));
    }

    private static bool ValidInteger(string val, int min)
    {
        int r = 0;
        try
        {
            r = int.Parse(val);
        }
        catch { return false; }

        if (r < min) { return false; }
        return true;
    }

    public static (List<int>, List<int>, List<int>, Fractions.Fraction) ArgumentsFromFile()
    {
        var A = new List<int>();
        var B = new List<int>();
        var N = new List<int>();
        var ProdN = new Fractions.Fraction();
        ProdN = 1;
        using (StreamReader sr = new StreamReader("CongruenceSystem.txt"))
        {
            string[] values = new string[2];
            string line;
            int ai, ni;
            // Read and display lines from the file until the end of
            // the file is reached.
            while ((line = sr.ReadLine()) != null)
            {
                try
                {
                    values = line.Split(' ');
                    ai = int.Parse(values[0]);
                    ni = int.Parse(values[1]);
                    A.Add(ai);
                    N.Add(ni);
                    ProdN *= ni;
                    if (values.Length > 2) { Print.InvalidFileFormat(); }
                }
                catch
                {
                     Print.InvalidFileFormat();
                }
            }
            return (A, B, N, ProdN);
        }
    }
    static public bool ValidBit(string input)
    {
        if (input == "1") { return true; }
        if (input == "0") { return true; }
        return false;
    }
}