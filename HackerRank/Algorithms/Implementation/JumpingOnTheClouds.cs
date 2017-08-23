// hackerrank.com/challenges/jumping-on-the-clouds

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] c_temp = Console.ReadLine().Split(' ');
        int[] c = Array.ConvertAll(c_temp,Int32.Parse);

        int pos = 0;
        int jumps = 0;

        while(pos < n) {
            if(pos+2 < n && c[pos+2]==0){
                pos += 2;
            } else {
                pos ++;
            }
            jumps++;

            if(pos == n - 1) {
                break;
            }
        }

        Console.WriteLine(jumps);
    }
}
