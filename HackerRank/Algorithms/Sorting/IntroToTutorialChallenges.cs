// hackerrank.com/challenges/tutorial-intro

using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        var v = Int32.Parse(Console.ReadLine());
        var n = Int32.Parse(Console.ReadLine());
        var ar = Console.ReadLine().Split();

        for(int i = 0; i < n; i++) {
            var num = Int32.Parse(ar[i]);

            if(num == v) {
                Console.WriteLine(i);
                return;
            }
        }
    }
}
