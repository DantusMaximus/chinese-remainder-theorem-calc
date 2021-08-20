using System;
using System.Collections.Generic;
namespace KinesiskaRestsatsen
{
    public class GeneratedCongruenceSystem : ICongruenceSystem
    {
        public int MaxValue { get; set; }
        public int Congruences { get; set; }
        public long ProdN { get; set; }
        public List<int> A { get; set; }
        public List<int> B { get; set; }
        public List<int> N { get; set; }
        public GeneratedCongruenceSystem()
        {
            this.A = new List<int>();
            this.B = new List<int>();
            this.N = new List<int>();
            this.MaxValue = 20;
            this.Congruences = 7;
            this.ProdN = 1;
            Random random = new Random();
            int ai, ni;
            for (int i = 0; i < Congruences; i++)
            {
                ni = GenerateNewNi();
                ai = random.Next(2, MaxValue+1);
                A.Add(ai % ni);
                N.Add(ni);
                ProdN *= ni;
            }

            int GenerateNewNi()
            {
                int temp;
                do { temp = random.Next(2, MaxValue+1); }
                while (!ValidNewNi(temp));
                return temp;
            }
            bool ValidNewNi(int temp)
            {
                foreach (int ni in N)
                {
                    if (Math.GCD(ni, temp) != 1)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}