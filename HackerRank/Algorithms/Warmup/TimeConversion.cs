// hackerrank.com/challenges/time-conversion

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string time = Console.ReadLine();
        int hour = Convert.ToInt32(time.Substring(0,2));
        char meridiem = time[8];
        if((meridiem == 'P' && hour != 12)||(meridiem == 'A' && hour == 12)) {
            hour += 12;
        }

        hour = hour % 24;

        Console.WriteLine(hour.ToString("00") + time.Substring(2,6));
    }
}
