// hackerrank.com/challenges/staircase

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        for(int i = 1; i < n+1; i++) {
            string stair = "";
            for(int j = 1; j < n+1; j++) {
                if(j+i>=n+1) {
                    stair += "#";
                }
                else {
                    stair += " ";
                }
            }
            Console.WriteLine(stair);

        }
    }
}
