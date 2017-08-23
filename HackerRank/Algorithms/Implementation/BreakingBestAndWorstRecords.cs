// hackerrank.com/challenges/breaking-best-and-worst-records

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int[] getRecord(int[] s){
        var highScore = s[0];
        var lowScore = s[0];
        var highCount = 0;
        var lowCount = 0;

        for(int i = 1; i < s.Length; i++) {
            if(s[i] > highScore) {
                highCount++;
                highScore = s[i];
            }

            if(s[i] < lowScore) {
                lowCount++;
                lowScore = s[i];
            }
        }

        return new int[2] {highCount , lowCount};;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] s_temp = Console.ReadLine().Split(' ');
        int[] s = Array.ConvertAll(s_temp,Int32.Parse);
        int[] result = getRecord(s);
        Console.WriteLine(String.Join(" ", result));
    }
}
