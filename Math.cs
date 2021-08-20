using System.IO;
using System;
using System.Collections.Generic;
namespace KinesiskaRestsatsen
{
    static public class Math
    {
        static private List<int> primes;
        static Math()
        {
            primes = new List<int>();
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("Primes.txt"))
                {
                    string line;
                    // Read and display lines from the file until the end of
                    // the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        primes.Add(int.Parse(line));
                    }
                }
            }
            catch (Exception e)
            {
                // Let the user know what went wrong.
                throw new SystemException(e.Message);
            }
        }
        public static int Phi(int num)
        {
            int phi = 0;
            for (int i = 1; i <= num; i++)
            {
                if (GCD(i, num) == 1) { phi++; }
            }
            return phi;
        }
        public static int GCD(int a, int b)
        {
            int rest = b;
            if (b > a)
            {//Sets a to be the largest value and b to be the smallest
                rest = a;
                a = b;
                b = rest;
            }
            while (rest > 1)
            {
                rest = a % b;
                if (rest == 0) { return b; }
                a = b;
                b = rest;
            }
            return 1;
        }
    }
}