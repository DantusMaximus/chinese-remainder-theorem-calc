using KinesiskaRestsatsen;
using System.IO;
using System.Collections.Generic;
using System;
using System.Numerics;
static public class MetaData{
    static public int PrimesUpperbound(string root){
        int maxVal = 0;
        Directory.SetCurrentDirectory(root);
        using (StreamReader sr = new StreamReader(root + @"\RemainderTheorem\data\Primes.txt"))
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