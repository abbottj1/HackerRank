// hackerrank.com/challenges/equal-stacks

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_n1 = Console.ReadLine().Split(' ');
        int n1 = Convert.ToInt32(tokens_n1[0]);
        int n2 = Convert.ToInt32(tokens_n1[1]);
        int n3 = Convert.ToInt32(tokens_n1[2]);
        string[] h1_temp = Console.ReadLine().Split(' ');
        string[] h2_temp = Console.ReadLine().Split(' ');
        string[] h3_temp = Console.ReadLine().Split(' ');
        LinkedList<int> h1 = new LinkedList<int>();
        LinkedList<int> h2 = new LinkedList<int>();
        LinkedList<int> h3 = new LinkedList<int>();

        int max = Math.Max(n1, Math.Max(n2, n3));

        int h1Count = 0;
        int h2Count = 0;
        int h3Count = 0;
        for(int i = 0; i < max; i++) {
            if(i < n1){
                int val = Int32.Parse(h1_temp[i]);
                h1.AddFirst(val);
                h1Count += val;
            }
            if(i < n2){
                int val = Int32.Parse(h2_temp[i]);
                h2.AddFirst(val);
                h2Count += val;
            }

            if(i < n3){
                int val = Int32.Parse(h3_temp[i]);
                h3.AddFirst(val);
                h3Count += val;
            }
        }

        while(!(h1Count==h2Count && h1Count==h3Count)) {
            int maxHeight = Math.Max(h1Count, Math.Max(h2Count, h3Count));

            if(h1Count == maxHeight) {
                h1Count -= h1.Last.Value;
                h1.RemoveLast();
            } else if(h2Count == maxHeight) {
                h2Count -= h2.Last.Value;
                h2.RemoveLast();
            } else if(h3Count == maxHeight) {
                h3Count -= h3.Last.Value;
                h3.RemoveLast();
            }
        }
        Console.WriteLine(h1Count);

    }

}
