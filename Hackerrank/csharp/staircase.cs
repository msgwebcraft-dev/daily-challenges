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

class Result
{

    /*
     * Complete the 'staircase' function below.
     *
     * The function accepts INTEGER n as parameter.
         #
        ##
       ###
      ####
     */
    // implementation starts 
    public static void staircase(int n)
    {
        for (int row = 0; row < n; row++){
            for (int col = 0; col < n; col++){
                if(row < col)Console.Write(" ");
            }
        for (int col = 0; col < n; col++){
            if(row >= col)Console.Write("#");
        }
            Console.WriteLine("");
        }

    }
    // Implementation Stops
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}
