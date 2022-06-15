using KinesiskaRestsatsen;
using System.IO;
using System.Collections.Generic;
using System;
using System.Numerics;
static public class MetaData{
    static public int PrimesUpperbound(){
        int maxVal = 0;
        using (StreamReader sr = new StreamReader(@"data\Primes.txt"))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                int i = int.Parse(line);
                if(i>maxVal){ maxVal = i;}
            }
        }
        return maxVal;
    }
}