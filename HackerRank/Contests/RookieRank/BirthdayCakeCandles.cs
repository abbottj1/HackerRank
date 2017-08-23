// hackerrank.com/contests/rookierank/challenges/birthday-cake-candles

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] height_temp = Console.ReadLine().Split(' ');
        int[] height = Array.ConvertAll(height_temp,Int32.Parse);

        int maxHeight = height[0];
        int maxCount = 1;

        for(int i = 1; i < n; i++){
            if(height[i] == maxHeight){
                maxCount++;
            } else if (height[i] > maxHeight) {
                maxHeight = height[i];
                maxCount = 1;
            }
        }

        Console.WriteLine(maxCount);
    }
}
