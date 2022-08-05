using System.Collections.Generic;
using System.Numerics;
namespace KinesiskaRestsatsen{
    public interface ICongruenceSystem{
        int Congruences { get; set; }
        BigInteger ProdN { get; set; }
        BigInteger Answear { get; set; }
        List<int> A { get; set;}
        List<int> B { get; set;}
        List<int> N { get; set;}
        BigInteger SolveCongruenceSystem(string root)
        {
            // om bi(n/ni) ≡ 1 (mod ni) får vi en lösning när vi multiplicerar med ai, vilket ger oss
            // bi ≡ (n/ni)^(phi.Phi(ni)-1) (mod ni)         ty         bi ≡ (n/ni)^-1 (mod ni)          och         (n/ni)^(phi.Phi(ni)) ≡ 1 (mod ni)
            var bFactors = new List<BigInteger>();
            var math = new Math(root);
            BigInteger b = 0;
            BigInteger e = 0;
            //Decides sollutions bi for each congruence
            for (int i = 0; i < Congruences; i++)
            {
                bFactors.Clear();
                b = ProdN / N[i];
                e = math.Phi(N[i]) - 1;
                while (e > 1)
                {
                     Reduce(ref b, ref e, N[i]);
                }
                foreach (BigInteger factor in bFactors)
                {
                    b *= factor;
                    b %= N[i];
                }
                b %= N[i];
                B.Add((int)b);
            }
            //Calculates answear modulo ProdN
            BigInteger answear = 0;
            for (int i = 0; i < Congruences; i++)
            {
                answear += A[i] * B[i] * (ProdN / N[i]);
                answear %= ProdN;
            }
            if(answear < 0){ answear += ProdN;}
            Answear = answear;
            return answear;
            void Reduce(ref BigInteger b, ref BigInteger e, int ni)
            {
                b %= ni;
                if (e % 2 == 1)
                {
                    bFactors.Add((b % ni));
                    e-=1;
                }
                if (e >= 2)
                {
                    bFactors.Add((math.PowMod(b, e / 2, ni)) % ni);
                    e /= 2;
                }
            }
        }
    }
}