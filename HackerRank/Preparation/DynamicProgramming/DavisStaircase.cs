using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Solution {

    // Complete the stepPerms function below.
    static int stepPerms(int n) {
        var memo = new long[n + 1];
        memo[0] = 1;
        return (int)(stepPerms(n, memo)%10000000007);
    }

    static long stepPerms(int n, long[] memo) {
        if (n < 0) {
            return 0;
        }

        if (n == 0) {
            return 1;
        }

        if(memo[n] != 0) {
            return memo[n];
        }

        long amount = 0;

        if (n >= 1) {
            amount += stepPerms(n - 1, memo);
        }

        if (n >= 2) {
            amount += stepPerms(n - 2, memo);
        }

        if (n >= 3) {
            amount += stepPerms(n - 3, memo);
        }

        memo[n] = amount;
        return amount;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int s = Convert.ToInt32(Console.ReadLine());

        for (int sItr = 0; sItr < s; sItr++) {
            int n = Convert.ToInt32(Console.ReadLine());

            int res = stepPerms(n);

            textWriter.WriteLine(res);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
