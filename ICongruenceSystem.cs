using System.Collections.Generic;
namespace KinesiskaRestsatsen{
    interface ICongruenceSystem{
        int Congruences { get; set; }
        long ProdN { get; set; }
        List<int> A { get; set;}
        List<int> B { get; set;}
        List<int> N { get; set;}
        void SolveCongruenceSystem()
        {
            //bi(n/ni) ≡ 1 (mod ni); är en lösning multiplicerat med ai, vilket ger oss
            // bi ≡ (n/ni)^(phi.Phi(ni)-1) (mod ni)
            // enligt eulers sats:  a^(phi.Phi(n)) ≡ 1 (mod n)
            // om a och n är relativt prima
            var bFactors = new List<long>();
            long b;
            int e;
            //Decides sollutions bi for each congruence
            for (int i = 0; i < Congruences; i++)
            {
                bFactors.Clear();
                b = ProdN / N[i];
                e = Math.Phi(N[i]) - 1;
                while (e > 1)
                {
                    Reduce(ref b, ref e, N[i]);
                }
                foreach (long factor in bFactors)
                {
                    b %= ProdN;
                    b *= factor;
                }
                B.Add((int)(b % N[i]));
            }
            //Calculates answear modulo ProdN
            long answear = 0;
            for (int i = 0; i < Congruences; i++)
            {
                answear += A[i] * B[i] * (ProdN / N[i]);
                answear %= ProdN;
            }
            Print.Results(A, N, ProdN, (answear % ProdN).ToString());
            void Reduce(ref long b, ref int e, int ni)
            {
                b %= ni;
                if (e % 2 == 1)
                {
                    bFactors.Add((b % ni));
                    e--;
                    return;
                }
                if (e > 2)
                {
                    bFactors.Add((int)(System.Math.Pow(b, e / 2) % ni));
                    e /= 2;
                }
                bFactors.Add((int)b);
                e--;
            }
        }
    }
}