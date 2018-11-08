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

    // Complete the minimumBribes function below.
    static void minimumBribes(int[] q) {
        var minimumBribes = 0;
        for (int person = q.Length - 1; person > 0; person--)
        {
            if ((person + 1) != q[person])
            {
                Swap(q, person, person - 1);
                minimumBribes++;
                
                if (person != 1 && (person + 1) != q[person])
                {
                    Swap(q, person, person - 2);
                    minimumBribes++;
                    
                   if ((person + 1) != q[person])
                   {
                       Console.WriteLine("Too chaotic");
                       return;
                   }
                }
            }
        }
                
        Console.WriteLine(minimumBribes);
    }
    
    static void Swap(int[] q, int a, int b)
    {
        var temp = q[a];
        q[a] = q[b];
        q[b] = temp;
    }

    static void Main(string[] args) {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] q = Array.ConvertAll(Console.ReadLine().Split(' '), qTemp => Convert.ToInt32(qTemp))
            ;
            minimumBribes(q);
        }
    }
}
