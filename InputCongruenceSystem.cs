using System.Collections.Generic;
using System.IO;
using Fractions;
namespace KinesiskaRestsatsen
{
    class InputCongurenceSystem : ICongruenceSystem
    {
        public int Congruences { get; set; }
        public Fraction ProdN { get; set; }
        public List<int> A { get; set; }
        public List<int> B { get; set; }
        public List<int> N { get; set; }
         public InputCongurenceSystem((List<int> , List<int> ,List<int>, Fraction) args)
        {
            this.A = args.Item1;
            this.B = args.Item2;
            this.N = args.Item3;
            this.ProdN = args.Item4;
            this.Congruences = A.Count;
        }
    }
}