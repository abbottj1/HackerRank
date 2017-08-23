// hackerrank.com/challenges/diagonal-difference

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];
        int diag0 = 0;
        int diag1 = 0;
        for(int a_i = 0; a_i < n; a_i++){
           string[] a_temp = Console.ReadLine().Split(' ');
           a[a_i] = Array.ConvertAll(a_temp,Int32.Parse);
           diag0 += a[a_i][a_i];
           diag1 += a[a_i][n-a_i-1];
        }

        Console.WriteLine(Math.Abs(diag0-diag1));
    }
}
