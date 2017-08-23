// hackerrank.com/challenges/kangaroo

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_x1 = Console.ReadLine().Split(' ');
        double x1 = Convert.ToDouble(tokens_x1[0]);
        double v1 = Convert.ToDouble(tokens_x1[1]);
        double x2 = Convert.ToDouble(tokens_x1[2]);
        double v2 = Convert.ToDouble(tokens_x1[3]);

        if(CompareInt(x1,x2) + CompareInt(v1,v2) != 0) {
            Console.WriteLine("NO");
        } else {
            double intercetion = (x2 - x1)/(v1 - v2);
            if(intercetion%1 == 0){
              Console.WriteLine("YES");
            } else {
              Console.WriteLine("NO");
            }
        }
    }

    static int CompareInt(double x, double y) {
        if(x > y) {
            return 1;
        } else if (y > x) {
            return -1;
        } else {
            return 0;
        }
    }
}
