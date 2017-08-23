// hackerrank.com/challenges/insertionsort1

using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void insertionSort(int[] ar) {
        var unsorted = ar[ar.Length-1];
        var currentIndex = ar.Length-2;

        while(currentIndex > -1 && ar[currentIndex] > unsorted) {
            ar[currentIndex + 1] = ar[currentIndex];
            Print(ar);
            currentIndex--;
        }

        ar[currentIndex + 1] = unsorted;
        Print(ar);
    }

    static void Print(int[] ar) {
        for(int j = 0; j < ar.Length; j++) {
            Console.Write(ar[j] + " ");
        }
        Console.WriteLine();
    }

    /* Tail starts here */
    static void Main(String[] args) {

        int _ar_size;
        _ar_size = Convert.ToInt32(Console.ReadLine());
        int [] _ar =new int [_ar_size];
        String elements = Console.ReadLine();
        String[] split_elements = elements.Split(' ');
        for(int _ar_i=0; _ar_i < _ar_size; _ar_i++) {
            _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
        }

        insertionSort(_ar);
    }
}
