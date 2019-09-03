using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Solution {

    /*
     * Complete the timeConversion function below.
     */
    static string timeConversion(string s) {
        bool ifPM = s.Contains("PM");
        string AMString = s.Substring(0, 8);
        string stringRem = s.Substring(2, 6);
        string first2 = s.Substring(0, 2);
        long first2int = long.Parse(first2);
        long addedInt = first2int + 12;

        if (first2int == 12) { //noon/midnight cases
            if (!ifPM) {
                return $"00{stringRem}";
            }
            else {
                return $"12{stringRem}";
            }
        }

        if (ifPM) {
            return $"{addedInt}{stringRem}";
        }
        else {
            return $"{first2}{stringRem}";
        }

        //account for i > 24, noon/midnight


        //cut substring
        //cut first 2 and convert to int.
        //add 12 to int
        //concat added time to substring
        /*
        if(ifPM) {
            Console.WriteLine($"{addedInt}{stringRem}");
        } else{
            Console.WriteLine($"{AMString}");
        }*/

    }

    static void Main(string[] args) {
        TextWriter tw = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = timeConversion(s);

        tw.WriteLine(result);

        tw.Flush();
        tw.Close();
    }
}
