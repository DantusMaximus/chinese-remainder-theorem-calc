using System;
using System.Collections.Generic;
namespace KinesiskaRestsatsen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            char userinput;
            do{
                Print.Prompt();
                userinput = (char)Console.Read();
            }
            while(!Input.Valid(userinput));
            ICongruenceSystem congruenceSystem;
            switch(userinput){
                case 'y': congruenceSystem = new InputCongurenceSystem();
                break;
                case 'X': congruenceSystem = new GeneratedCongruenceSystem();
                break;
                default: congruenceSystem = new GeneratedCongruenceSystem();
                break;
            }
            congruenceSystem.SolveCongruenceSystem();
        }
        
    }
}