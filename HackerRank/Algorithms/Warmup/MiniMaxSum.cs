// hackerrank.com/challenges/mini-max-sum

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] arr_temp = Console.ReadLine().Split(' ');
        long[] arr = Array.ConvertAll(arr_temp,Int64.Parse);

        Array.Sort(arr);
        Console.WriteLine(string.Format("{0} {1}",arr[0]+arr[1]+arr[2]+arr[3], arr[4]+arr[3]+arr[2]+arr[1]));
    }
}
