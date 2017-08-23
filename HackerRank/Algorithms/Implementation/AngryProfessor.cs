// hackerrank.com/challenges/angry-professor

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int t = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < t; a0++){
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp,Int32.Parse);
            int late = 0;
            int onTime = 0;
            for(int i = 0; i < n; i++) {
                if(a[i] > 0) {
                    late++;
                } else {
                    onTime++;
                }

                if(n-late < k || onTime >= k){
                    break;
                }
            }

            if(n-late < k){
                Console.WriteLine("YES");
            } else {
                Console.WriteLine("NO");
            }
        }
    }
}
