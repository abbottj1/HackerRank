// hackerrank.com/challenges/funny-string

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static string funnyString(string s){
        // Complete this function
        for(int i = 1; i < s.Length/2+1; i++) {
            if(Math.Abs(s[i] - s[i - 1]) != Math.Abs(s[s.Length - 1 - i] - s[s.Length - i])) {
                return "Not Funny";
            }
        }

        return "Funny";
    }

    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < q; a0++){
            string s = Console.ReadLine();
            string result = funnyString(s);
            Console.WriteLine(result);
        }
    }
}
