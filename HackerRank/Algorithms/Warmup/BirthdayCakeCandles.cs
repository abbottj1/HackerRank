// hackerrank.com/challenges/birthday-cake-candles

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int birthdayCakeCandles(int n, int[] ar) {
        Array.Sort(ar);

        int numberOfTallest = 1;
        int tall = ar[n-1];

        if(n <= 1)
        {
            return n;
        }

        for(int i = n-2; i >=0; i--) {
            if(ar[i] != tall)
                break;
            else
                numberOfTallest++;
        }

        return numberOfTallest;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        int result = birthdayCakeCandles(n, ar);
        Console.WriteLine(result);
    }
}
