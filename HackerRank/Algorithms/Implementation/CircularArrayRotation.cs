// hackerrank.com/challenges/circular-array-rotation

using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        /* Enter your code here. Read input from STDIN. Print output to STDOUT. Your class should be named Solution */
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] firstLine = Array.ConvertAll(arr_temp,Int32.Parse);
        int n = firstLine[0];
        int k = firstLine[1];
        int q = firstLine[2];
        arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);

        int[] results = new int[n];

        for(int j = 0; j < n; j++) {
            int nextPos = (k + j)%n;
            results[nextPos] = arr[j];
        }


        for(int i = 0; i < q; i++) {
            int m = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(results[m]);
        }

    }
}
