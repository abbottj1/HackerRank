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

    // Complete the maxSubsetSum function below.
    static int maxSubsetSum(int[] arr) {
        if (arr.Length == 0) 
        {
            return 0;
        }

        arr[0] = Math.Max(0, arr[0]);
        if (arr.Length == 1) 
        {
            return arr[0];
        }

        arr[1] = Math.Max(arr[0], arr[1]);
        for (int i = 2; i < arr.Length; i++)
        {
            arr[i] = Math.Max(arr[i-1], arr[i]+arr[i-2]);
        }
        return arr[arr.Length-1];
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int n = Convert.ToInt32(Console.ReadLine());

        int[] arr = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
        ;
        int res = maxSubsetSum(arr);

        textWriter.WriteLine(res);

        textWriter.Flush();
        textWriter.Close();
    }
}
