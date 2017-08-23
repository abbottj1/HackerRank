// hackerrank.com/challenges/cut-the-sticks

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
        int[] stickCount = new int[1000];
        for(int i = 0; i < n; i++) {
            stickCount[arr[i]-1]++;
        }

        Console.WriteLine(n);
        for(int j = 0; j < 1000; j++) {
            if(stickCount[j] - n == 0){
                break;
            }
            if(stickCount[j] != 0){
                n = n - stickCount[j];
                Console.WriteLine(n);
            }
        }
    }
}
