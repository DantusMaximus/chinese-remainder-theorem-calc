using System;
using System.Collections.Generic;
using System.Numerics;
namespace KinesiskaRestsatsen{
    static class Print{
        static public void PromptCongSysSpec(){
            Console.Clear();
            Console.WriteLine("Do you want to solve the congruence system that is specified in the file \"CongruenceSystem.txt\"[0] or do you want to solve a generated one[1]?");
        }

        public static void PromptGenSpec(int maxVal){
            Console.Clear();
            Console.WriteLine($"Please enter the max value of any conruence modulus (no bigger than {maxVal}) and the total amount of congruences in the system");
        }
        static public void Results(List<int> a, List<int> n, BigInteger prodN, BigInteger sollution){
            if(prodN ==1){return;}
            Console.Clear();
            Console.WriteLine("The Congruence System");
            for(int i = 0; i < a.Count; i++){
                Console.WriteLine($"x ≡ {a[i]}   mod({n[i]})");
            }
            Console.WriteLine("Has the solutions:    x = " + sollution + " + n*" + prodN + "    n ∈ Z");
        }
        
        public static void InvalidFileFormat(){
            throw new System.Exception("Invalid format in file CongruenceSystem.txt");
        }
    }
}