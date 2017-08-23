// hackerrank.com/challenges/non-divisible-subset

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] a_temp = Console.ReadLine().Split(' ');
        int[] a = Array.ConvertAll(a_temp,Int32.Parse);
        int[] mods = new int[k];

        int results = 0;
        for(int i = 0; i < n; i++) {
            mods[a[i]%k]++;
        }

        double kDiv2 = (double) k / 2;
        for(int i=1; i < kDiv2 ;i++) {
            if(mods[i] >= mods[k-i]) {
                results += mods[i];
            } else {
                results += mods[k-i];
            }
        }

        if(mods[0] > 0){
            results++;
        }

        if(k%2 == 0 && mods[k/2] > 0){
            results++;
        }

        Console.WriteLine(results);
    }
}
