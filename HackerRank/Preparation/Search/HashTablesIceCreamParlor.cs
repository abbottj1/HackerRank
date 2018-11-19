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

    // Complete the whatFlavors function below.
    static void whatFlavors(int[] cost, int money) {
        var costs = new List<Tuple<int,int>>();
        
        //Add costs to list with indexs as tuple
        for(int i = 0; i < cost.Length; i++)
        {
            if (cost[i] < money)
            {
                costs.Add(new Tuple<int,int>(cost[i], i + 1));
            }
        }
        
        //Sort tuple list by costs
        costs = costs.OrderBy(c => c.Item1).ToList();

        //Work inwards from both ends of the list to find the matching pair
        var lowerCostIndex = 0;
        var hightCostIndex = costs.Count - 1;
        
        while(costs[lowerCostIndex].Item1 + costs[hightCostIndex].Item1 != money)
        {
            if(costs[lowerCostIndex].Item1 + costs[hightCostIndex].Item1 > money)
            {
                hightCostIndex--;
            }
            else
            {
                lowerCostIndex++;
            }
        }
        
        //Print the result in the correct order
        if(costs[lowerCostIndex].Item2 < costs[hightCostIndex].Item2)
        {
            Console.WriteLine(costs[lowerCostIndex].Item2 + " " + costs[hightCostIndex].Item2);
        }
        else
        {
            Console.WriteLine(costs[hightCostIndex].Item2 + " " + costs[lowerCostIndex].Item2);
        }
    }

    static void Main(string[] args) {
        int t = Convert.ToInt32(Console.ReadLine());

        for (int tItr = 0; tItr < t; tItr++) {
            int money = Convert.ToInt32(Console.ReadLine());

            int n = Convert.ToInt32(Console.ReadLine());

            int[] cost = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), costTemp => Convert.ToInt32(costTemp))
            ;
            whatFlavors(cost, money);
        }
    }
}
