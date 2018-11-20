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

    // Complete the isBalanced function below.
    static string isBalanced(string s) {
        var stack = new Stack<char>();
        foreach(var c in s)
        {
            switch(c)
            {
                case '}':
                    if(!checkBalanced(stack, '{'))
                    {
                        return "NO";
                    }

                    break;
                case ')':
                    if(!checkBalanced(stack, '('))
                    {
                        return "NO";
                    }

                    break;
                case ']':
                    if(!checkBalanced(stack, '['))
                    {
                        return "NO";
                    }

                    break;
                default:
                    stack.Push(c);
                    break;
            }
        }

        if(stack.Count > 0)
        {
            return "NO";
        }

        return "YES";
    }

    static bool checkBalanced(Stack<char> stack, char expectedChar)
    {
        if(stack.Count == 0)
        {
            return false;
        }

        var gotChar = stack.Pop();

        return expectedChar == gotChar;
    }

    static void Main(string[] args) {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            string s = Console.ReadLine();

            string result = isBalanced(s.Trim());

            textWriter.WriteLine(result);
        }

        textWriter.Flush();
        textWriter.Close();
    }
}
