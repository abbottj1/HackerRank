// hackerrank.com/challenges/cats-and-a-mouse

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int q = Convert.ToInt32(Console.ReadLine());
        for(int a0 = 0; a0 < q; a0++){
            string[] tokens_x = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(tokens_x[0]);
            int b = Convert.ToInt32(tokens_x[1]);
            int c = Convert.ToInt32(tokens_x[2]);

            var catADistance = Math.Abs(a - c);
            var catBDistance = Math.Abs(b - c);

            if(catADistance == catBDistance) {
                Console.WriteLine("Mouse C");
            }
            else if (catADistance < catBDistance) {
                Console.WriteLine("Cat A");
            }
            else {
                Console.WriteLine("Cat B");
            }
        }
    }
}
