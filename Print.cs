using System;
using System.Collections.Generic;
using Fractions;
namespace KinesiskaRestsatsen{
    static class Print{
        static public void PromptCongSysSpec(){
            Console.Clear();
            Console.WriteLine("Do you want to solve the congruence system that is specified in the file \"CongruenceSystem.txt\"[0] or do you want to solve a generated one[1]?");
        }

        public static void PromptGenSpec(){
            Console.Clear();
            Console.WriteLine("Please enter the max value of any conruence modulus and the total amount of congruences in the system");
        }
        static public void Results(List<int> a, List<int> n, Fraction prodN, string sollution){
            if(prodN ==1){return;}
            Console.Clear();
            Console.WriteLine("The Congruence System");
            for(int i = 0; i < a.Count; i++){
                Console.WriteLine($"x ≡ {a[i]}   mod({n[i]})");
            }
            Console.WriteLine("Has the solutions:    x = " + sollution + " + n*" + prodN + "    n ∈ Z");
        }
        public static void CouldNotGenerate(){
            Console.WriteLine("There is not a sufficent ammount of primes less than or equal to the given max value for there to be such a congruence system");
            System.Environment.Exit(1);
        }
        
        public static void InvalidFileFormat(){
            Console.WriteLine("Invalid format in file CongruenceSystem.txt");
            System.Environment.Exit(1);
        }
    }
}