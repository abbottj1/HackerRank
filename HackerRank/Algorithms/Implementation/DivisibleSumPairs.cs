// hackerrank.com/challenges/divisible-sum-pairs

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
        double[] a = Array.ConvertAll(a_temp,Double.Parse);
        int result = 0;
        for(int i = 0; i<n; i++){
            for(int j=i+1; j<n; j++) {
                if((a[i] + a[j])/k%1 == 0){
                    result++;
                }
            }
        }
        Console.WriteLine(result);
    }
}
