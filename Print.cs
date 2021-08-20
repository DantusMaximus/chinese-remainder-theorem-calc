using System;
using System.Collections.Generic;
namespace KinesiskaRestsatsen{
    static class Print{
        static public void Prompt(){
            Console.Clear();
            Console.WriteLine("Do you want to solve the congruence system that is specified in the file \"CongruenceSystem.txt\"[0] or do you want to generate one[1]?");
        }
        static public void Results(List<int> a, List<int> n, long prodN, string sollution){
            if(prodN ==1){return;}
            Console.Clear();
            Console.WriteLine("The Congruence System");
            for(int i = 0; i < a.Count; i++){
                Console.WriteLine($"x ≡ {a[i]}   mod({n[i]})");
            }
            Console.WriteLine("Has the solution:    x = " + sollution + " + n*" + prodN);
        }

        public static void InvalidCongruence(int coeff, int ai, int ni)
        {
            Console.WriteLine($"The Congruence  {coeff}x ≡ {ai}  mod({ni})  is not valid to the congruance system due to having multiple sollutions in the same modulus");
            Console.WriteLine();
        }
        public static void CouldNotGenerate(){
            Console.WriteLine("There is not a sufficent ammount of primes less than or equal to the given max value (\"MaxValue\") for there to be such a congruence system with \"Congruences\" congruences");
            System.Environment.Exit(0);
        }
    }
}