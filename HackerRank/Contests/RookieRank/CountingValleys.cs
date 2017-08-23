// hackerrank.com/contests/rookierank/challenges/counting-valleys

using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string upDown = Console.ReadLine();

        int level = 0;
        int valleys = 0;
        for(int i = 0; i < n; i++) {
            if(upDown[i] == 'U') {
                level++;
            } else {
                level--;
                if(level == -1){
                    valleys++;
                }
            }
        }

        Console.WriteLine(valleys);
    }
}
