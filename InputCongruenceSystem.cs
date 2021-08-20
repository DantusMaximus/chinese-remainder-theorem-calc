using System.Collections.Generic;
using System.IO;
namespace KinesiskaRestsatsen
{
    class InputCongurenceSystem : ICongruenceSystem
    {
        public int Congruences { get; set; }
        public long ProdN { get; set; }
        public List<int> A { get; set; }
        public List<int> B { get; set; }
        public List<int> N { get; set; }
        public InputCongurenceSystem()
        {
            this.A = new List<int>();
            this.B = new List<int>();
            this.N = new List<int>();
            this.ProdN = 1;
            //The Congruence system is input to the file "CongruenceSystem.txt", each line corresponding to one congruence in the form of   coeffic * x ≡ ai
            //4 2
            //2 3
            //5 5
            //3 2 7
            //coeffic ai ni ai ni
            //corresponding to the kongruence
            ReadCongruenceSystem();
            this.Congruences = A.Count;
        }


        void ReadCongruenceSystem()
        {
            using (StreamReader sr = new StreamReader("CongruenceSystem.txt"))
            {
                string[] values = new string[2];
                string line;
                int ai, ni;
                // Read and display lines from the file until the end of
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    ai = 0;
                    ni = 0;
                    values = line.Split(' ');
                    if (values.Length == 2)
                    {
                        ai = int.Parse(values[0]);
                        ni = int.Parse(values[1]);
                    }
                    if (values.Length == 3){
                    int coeff = int.Parse(values[0]);
                    ai = int.Parse(values[1]);
                    ni = int.Parse(values[2]);
                    if (Math.GCD(coeff, ni)>1){ Print.InvalidCongruence(coeff, ai, ni);  continue; }
                    MakeLefthandsideNonFactored(coeff, ref ai, ni);
                    }
                    A.Add(ai);
                    N.Add(ni);
                    ProdN *= ni;
                }
            }
        void MakeLefthandsideNonFactored(int coeff, ref int ai, int ni)
        {
            while (ai % coeff != 0)
            {
                ai += ni;
            }
            ai /= coeff;
            ai %= ni;
        }

        }
    }
}