// hackerrank.com/challenges/coin-change

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static long getWays(long total, long[] coins){
        var table = new long[total + 1, coins.Length];
        int rowLength = table.GetLength(0);
        int colLength = table.GetLength(1);

        for(int i =  0; i < colLength; i++) {
            table[0,i] = 1;
        }

        for(int i =  0; i < rowLength; i++) {
            if(i % coins[0] == 0) {
                table[i,0] = 1;
            }
        }

        for (int col = 1; col < colLength; col++)
        {
            for (int row = 1; row < rowLength; row++)
            {
                if(row < coins[col]) {
                    table[row, col] = table[row, col - 1];
                }
                else {
                        table[row, col] = table[row - coins[col], col] + table[row, col - 1];
                }
            }
        }

        return table[rowLength-1, colLength-1];
    }

    static void Main(String[] args) {
        string[] tokens_n = Console.ReadLine().Split(' ');
        int n = Convert.ToInt32(tokens_n[0]);
        int m = Convert.ToInt32(tokens_n[1]);
        string[] c_temp = Console.ReadLine().Split(' ');
        long[] c = Array.ConvertAll(c_temp,Int64.Parse);
        // Print the number of ways of making change for 'n' units using coins having the values given by 'c'
        long ways = getWays(n, c);
        Console.WriteLine(ways);
    }
}
