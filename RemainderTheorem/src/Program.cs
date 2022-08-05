using System;
using System.Collections.Generic;
using System.Numerics;
using System.IO;
namespace KinesiskaRestsatsen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            string root = "";
            root = Directory.GetCurrentDirectory();
            Directory.SetCurrentDirectory(root);
            ICongruenceSystem congruenceSystem = Read.CoungruenceSystem(root);
            congruenceSystem.Answear = congruenceSystem.SolveCongruenceSystem(root);
            Print.Results(congruenceSystem.A, congruenceSystem.N, congruenceSystem.ProdN, congruenceSystem.Answear);
        }
        
    }
}