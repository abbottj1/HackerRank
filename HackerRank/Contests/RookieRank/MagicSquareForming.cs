// hackerrank.com/contests/rookierank/challenges/magic-square-forming

using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int[,] matrix = new int[3,3];
        for(int i = 0; i < 3; i++) {
            string[] row_temp = Console.ReadLine().Split(' ');
            int[] row = Array.ConvertAll(row_temp,Int32.Parse);
            for(int j = 0; j < 3; j++) {
                matrix[i,j] = row[j];
            }
        }

        int minCount = 0;
        int midChange = 0;
        //5 always in middle
        midChange = midChange + Math.Abs(matrix[1,1]-5);

        int[] ring = new int[8]{matrix[0,0],matrix[0,1],matrix[0,2],matrix[1,2],matrix[2,2],matrix[2,1],matrix[2,0],matrix[1,0]};

        int[] sol1 = new int[8]{8,1,6,7,2,9,4,3};
        int currentDiff = midChange + countDiff(ring,sol1);
        minCount = currentDiff;
        int[] sol2 = new int[8]{4,3,8,1,6,7,2,9};
        currentDiff = midChange + countDiff(ring,sol2);
        if(currentDiff < minCount){
            minCount = currentDiff;
        }
        int[] sol3 = new int[8]{2,9,4,3,8,1,6,7};
        currentDiff = midChange + countDiff(ring,sol3);
        if(currentDiff < minCount){
            minCount = currentDiff;
        }
        int[] sol4 = new int[8]{6,7,2,9,4,3,8,1};
        currentDiff = midChange + countDiff(ring,sol4);
        if(currentDiff < minCount){
            minCount = currentDiff;
        }
        int[] sol5 = new int[8]{6,1,8,3,4,9,2,7};
        currentDiff = midChange + countDiff(ring,sol5);
        if(currentDiff < minCount){
            minCount = currentDiff;
        }
        int[] sol6 = new int[8]{8,3,4,9,2,7,6,1};
        currentDiff = midChange + countDiff(ring,sol6);
        if(currentDiff < minCount){
            minCount = currentDiff;
        }
        int[] sol7 = new int[8]{4,9,2,7,6,1,8,3};
        currentDiff = midChange + countDiff(ring,sol7);
        if(currentDiff < minCount){
            minCount = currentDiff;
        }
        int[] sol8 = new int[8]{2,7,6,1,8,3,4,9};
        currentDiff = midChange + countDiff(ring,sol8);
        if(currentDiff < minCount){
            minCount = currentDiff;
        }

        Console.WriteLine(minCount);

    }

    static int countDiff(int[] a1, int[] a2) {
        int diff = 0;
        for(int i = 0; i < 8; i++) {
            diff = diff + Math.Abs(a1[i]-a2[i]);
        }
        return diff;
    }
}
