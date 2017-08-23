// hackerrank.com/challenges/compare-the-triplets

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_a0 = Console.ReadLine().Split(' ');
        int a0 = Convert.ToInt32(tokens_a0[0]);
        int a1 = Convert.ToInt32(tokens_a0[1]);
        int a2 = Convert.ToInt32(tokens_a0[2]);
        string[] tokens_b0 = Console.ReadLine().Split(' ');
        int b0 = Convert.ToInt32(tokens_b0[0]);
        int b1 = Convert.ToInt32(tokens_b0[1]);
        int b2 = Convert.ToInt32(tokens_b0[2]);

        int aResult = cI(a0, b0) + cI(a1, b1) + cI(a2, b2);
        int bResult = cI(b0, a0) + cI(b1, a1) + cI(b2, a2);

        Console.WriteLine(aResult + " " + bResult);
    }

    static int cI(int a, int b){
        if(a > b){
            return 1;
        }

        return 0;
    }
}
