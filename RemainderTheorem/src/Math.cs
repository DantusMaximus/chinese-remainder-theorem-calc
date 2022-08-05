using System.IO;
using System;
using System.Collections.Generic;
using System.Numerics;
namespace KinesiskaRestsatsen
{
    public class Math
    {
        public List<int> primes;
        public Math(string root)
        {
            primes = new List<int>();
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                Directory.SetCurrentDirectory(root);
                using (StreamReader sr = new StreamReader(root + @"\RemainderTheorem\data\Primes.txt"))
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
                throw new SystemException("Couldn't find file, current file : " + Directory.GetCurrentDirectory());
            }
        }
        public int Phi(int num)
        {
            int phi = 0;
            for (int i = 1; i <= num; i++)
            {
                if (GCD(i, num) == 1) { phi++; }
            }
            return phi;
        }
        public int GCD(int a, int b)
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
        public BigInteger PowMod(BigInteger b, BigInteger e, int ni){
            BigInteger result = 1;
            while(e > 0){
                result *= b;
                result %= ni;
                e-= 1;
            }
            return result;
        }
    }
}