using System;
using System.Collections.Generic;
namespace KinesiskaRestsatsen{
    static class Print{
        static public void Prompt(){
            Console.WriteLine("Do you want to solve the congruence system that is specified in the file \"CongruenceSystem.txt\"? [y for yes, n for no]");
        }
        static public void Results(List<int> a, List<int> n, long prodN, string sollution){
            Console.WriteLine("The Congruence System");
            for(int i = 0; i < a.Count; i++){
                Console.WriteLine($"x ≡ {a[i]}   mod({n[i]})");
            }
            Console.WriteLine("Has the solution x= " + sollution + "+ n*" + prodN);
        }
    }
}