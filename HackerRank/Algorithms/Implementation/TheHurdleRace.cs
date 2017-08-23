// hackerrank.com/challenges/the-hurdle-race

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int k = Convert.ToInt32(tokens_n[1]);
        string[] height_temp = Console.ReadLine().Split(' ');
        int[] height = Array.ConvertAll(height_temp,Int32.Parse);

        var tallest = height[0];
        for(int i = 1; i < height.Length; i++)
        {
            if(height[i] > tallest)
            {
                tallest = height[i];
            }
        }

        var drinksNeeded = tallest - k;

        if(drinksNeeded < 0) {
            drinksNeeded = 0;
        }

        Console.WriteLine(drinksNeeded);
    }
}
