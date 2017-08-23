// hackerrank.com/challenges/plus-minus

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        double pos = 0;
        double neg = 0;
        double eq = 0;

        for(int i = 0; i < n; i++) {
            if(arr[i] > 0 ) {
                pos++;
            } else if(arr[i] < 0) {
                neg++;
            } else {
                eq++;
            }
        }
        double nDob = Convert.ToDouble(n);
        Console.WriteLine(pos == 0 ? pos : pos/nDob);
        Console.WriteLine(neg == 0 ? neg : neg/nDob);
        Console.WriteLine(eq == 0 ? eq : eq/nDob);
    }
}
