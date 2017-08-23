// hackerrank.com/challenges/camelcase

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string s = Console.ReadLine();

        var words = 1;
        foreach (var c in s) {
            if (c > 64 && c < 91)
                words++;
        }

        Console.Write(words);
    }
}
