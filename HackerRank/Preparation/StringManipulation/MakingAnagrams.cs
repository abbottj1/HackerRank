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

    // Complete the makeAnagram function below.
    static int makeAnagram(string a, string b) {
        var aFrequency = populateFrequency(a);
        var bFrequency = populateFrequency(b);
        
        var diffs = 0;
        
        for(int i = 0; i < aFrequency.Length; i++)
        {
            if (aFrequency[i] != bFrequency[i])
            {
                diffs = diffs + Math.Abs(aFrequency[i] - bFrequency[i]);
            }
        }

        return diffs;
    }
    
    static int[] populateFrequency(string word)
    {
        var frequency = new int[26];
        
        for (int i = 0; i < word.Length; i++)
        {
            frequency[word[i] - 97]++;
        }
        
        return frequency;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string a = Console.ReadLine();

        string b = Console.ReadLine();

        int res = makeAnagram(a, b);

        textWriter.WriteLine(res);

        textWriter.Flush();
        textWriter.Close();
    }
}
