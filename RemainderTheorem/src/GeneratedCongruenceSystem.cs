using System;
using System.Collections.Generic;
using System.Numerics;
namespace KinesiskaRestsatsen
{
    public class GeneratedCongruenceSystem : ICongruenceSystem
    {
        public int MaxValue { get; set; }
        public int Congruences { get; set; }
        public BigInteger ProdN { get; set; }
        public BigInteger Answear { get; set; }
        public List<int> A { get; set; }
        public List<int> B { get; set; }
        public List<int> N { get; set; }
        public GeneratedCongruenceSystem((int,int) args, string root)
        //A question that comes to mind when generating different congruence system are:
        //For any   n ∈ Z+  being the upperbound of each modulus in the reffered congruence systems, how many possible combinations of congruence systems is there?
        {
            var math = new Math(root);
            this.MaxValue = args.Item1;
            this.Congruences = args.Item2;
            A = new List<int>();
            B = new List<int>();
            N = new List<int>();
            this.ProdN = 1;
            Random random = new Random();
            int ai, ni;

            for (int i = 0; i < Congruences; i++)
            {
                ni = GenerateNewNi();
                if (ni == -1) {A.Clear(); N.Clear(); GenerateCongruencesWithPrimeNi(); break;}
                ai = random.Next(2, MaxValue + 1);
                A.Add(ai % ni);
                N.Add(ni);
                ProdN *= ni;
            }



            int GenerateNewNi()
            {

                int temp, tries = 0;
                do { temp = random.Next(2, MaxValue + 1); tries++; }
                while (!ValidNewNi(temp) && tries < MaxValue);
                if (tries == MaxValue) { return -1; }
                return temp;
            }


            bool ValidNewNi(int temp)
            {
                foreach (int ni in N)
                {
                    if (math.GCD(ni, temp) != 1)
                    {
                        return false;
                    }
                }
                return true;
            }


            void GenerateCongruencesWithPrimeNi()
            {
                for (int i = 0; i < Congruences; i++)
            {
                if(math.primes[i]>MaxValue){ throw new System.Exception("There is not a sufficent ammount of primes less than or equal to the given max value for there to be such a congruence system"); }
                ni = math.primes[i];
                ai = random.Next(2, MaxValue + 1);
                A.Add(ai % ni);
                N.Add(ni);
                ProdN *= ni;
            }
            }
        }
    }
}