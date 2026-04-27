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
     */

    public static void staircase(int n)
    {
        for (int i = 1; i <= n; i++)
        {
        int spacesCount = n - i;
        string line = new string(' ', spacesCount) + new string('#', i);
        Console.WriteLine(line);
        }
    }


}

class Solution
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine()!;
        if (!string.IsNullOrEmpty(input))
        {
            int n = Convert.ToInt32(input.Trim());
            Result.staircase(n);
        }
    }
}
