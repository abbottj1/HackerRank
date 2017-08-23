// hackerrank.com/challenges/big-sorting

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        var unsorted = new string[n];
        var uniqueNumbers = new Dictionary<string,int>();
        var uniqueCount = 0;
        for(int unsorted_i = 0; unsorted_i < n; unsorted_i++){
            var number = Console.ReadLine();
            if(uniqueNumbers.ContainsKey(number)) {
               uniqueNumbers[number] = uniqueNumbers[number] + 1;
            }
            else {
                uniqueNumbers.Add(number,1);
                unsorted[uniqueCount] = number;
                uniqueCount++;
            }
        }

        QuickSort(unsorted, 0, uniqueCount - 1);

        for(int i = 0; i < uniqueCount; i++) {
            for(int j = 0; j < uniqueNumbers[unsorted[i]]; j++) {
                Console.WriteLine(unsorted[i]);
            }
        }
    }

    static void QuickSort(string[] unsorted, int start, int end) {
        if (start < end) {
            var partition = Partition(unsorted, start, end);
            QuickSort(unsorted, start, partition - 1);
            QuickSort(unsorted, partition + 1, end);
        }
    }

    static int Partition(string[] unsorted, int start, int end) {
        var pivot = unsorted[end];
        var i = start - 1;

        for (int j = start; j < end; j++) {
            if (LessThan(unsorted[j], pivot)) {
                i++;
                Swap(unsorted, i, j);
            }
        }

        if (LessThan(unsorted[end], unsorted[i + 1]))
        {
            Swap(unsorted, i + 1, end);
        }

        return i + 1;
    }

    static void Swap(string[] unsorted, int first, int second) {
        var temp = unsorted[first];
        unsorted[first] = unsorted[second];
        unsorted[second] = temp;
    }

    static bool LessThan(string first, string second) {
        if(first.Length < second.Length) {
            return true;
        }

        if(first.Length > second.Length) {
            return false;
        }

        if(first.CompareTo(second) < 0) {
            return true;
        }
        else {
            return false;
        }
    }
}
