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
            //The Congruence system is input to the file "CongruenceSystem.txt" with the following syntax:
            //4 10
            //2 7
            //5 11
            //ai ni
            using (StreamReader sr = new StreamReader("CongruenceSystem.txt"))
            {
                string[] values = new string[2];
                string line;
                // Read and display lines from the file until the end of
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    values = line.Split(' ');

                    int ai = int.Parse(values[0]);
                    int ni = int.Parse(values[1]);

                    A.Add(ai);
                    N.Add(ni);
                    ProdN *= ni;
                }
            }
            this.Congruences = A.Count;
        }
    }
}