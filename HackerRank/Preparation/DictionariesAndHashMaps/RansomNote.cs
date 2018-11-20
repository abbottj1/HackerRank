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

    // Complete the checkMagazine function below.
    static void checkMagazine(string[] magazine, string[] note) {
        var magazineDictionary = new Dictionary<string, int>();

        for(int i = 0; i < magazine.Length; i++)
        {
            var word = magazine[i];
            if (magazineDictionary.ContainsKey(word))
            {
                magazineDictionary[word] = magazineDictionary[word] + 1;
            }
            else
            {
                magazineDictionary.Add(word, 1);
            }
        }

        for(int i = 0; i < note.Length; i++)
        {
            var word = note[i];
            if (magazineDictionary.ContainsKey(word))
            {
                magazineDictionary[word] = magazineDictionary[word] - 1;

                if (magazineDictionary[word] == 0)
                {
                    magazineDictionary.Remove(word);
                }
            }
            else
            {
                Console.WriteLine("No");
                return;
            }
        }
        
        Console.WriteLine("Yes");
    }

    static void Main(string[] args) {
        string[] mn = Console.ReadLine().Split(' ');

        int m = Convert.ToInt32(mn[0]);

        int n = Convert.ToInt32(mn[1]);

        string[] magazine = Console.ReadLine().Split(' ');

        string[] note = Console.ReadLine().Split(' ');

        checkMagazine(magazine, note);
    }
}
