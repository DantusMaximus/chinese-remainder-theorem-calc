using System;
using System.Numerics;
using System.IO;
using System.Collections.Generic;
namespace Testing
{
    static public class Helper
    {
        static public int LocateErrors(List<int> aList,List<int> mList, BigInteger n){
            int j = 0;
            for(int i = 0; i < aList.Count ; i++){
                if(n % mList[i] != aList[i]){
                    j++;
                }
            }
            return j;
        }
    }
}