// hackerrank.com/challenges/insertionsort2

using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void insertionSort(int[] ar) {
        for(int i = 1; i < ar.Length; i++) {
            var unsorted = ar[i];
            var currentIndex = i-1;

            while(currentIndex > -1 && ar[currentIndex] > unsorted) {
                ar[currentIndex + 1] = ar[currentIndex];
                currentIndex--;
            }

            ar[currentIndex + 1] = unsorted;
            Print(ar);
        }
    }

    static void Print(int[] ar) {
        for(int j = 0; j < ar.Length; j++) {
            Console.Write(ar[j] + " ");
        }
        Console.WriteLine();
    }
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
