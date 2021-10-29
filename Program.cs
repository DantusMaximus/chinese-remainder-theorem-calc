using System;
using System.Collections.Generic;
using System.Numerics;

namespace KinesiskaRestsatsen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            ICongruenceSystem congruenceSystem = Read.CoungruenceSystem();
            congruenceSystem.SolveCongruenceSystem();
        }
        
    }
}