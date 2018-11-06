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

    // Complete the sockMerchant function below.
    static int sockMerchant(int n, int[] ar) {
        var colorsStock = new int[100];
        for(int stockIndex = 0; stockIndex < n; stockIndex++)
        {
            colorsStock[ar[stockIndex] - 1]++;
        }
        
        var totalSocks = 0;
        
        for(int colorIndex = 0; colorIndex < 100; colorIndex++)
        {
            var fullPairs = colorsStock[colorIndex] - (colorsStock[colorIndex] % 2);
            totalSocks = totalSocks + (fullPairs/2);
        }
        
        return totalSocks;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] ar = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), arTemp => Convert.ToInt32(arTemp))
        ;
        int result = sockMerchant(n, ar);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
