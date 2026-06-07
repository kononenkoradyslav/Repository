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
     * Complete the 'diagonalDifference' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts 2D_INTEGER_ARRAY arr as parameter.
     */
    public static int diagonalDifference(List<List<int>> arr)
    {
        int primaryDiagonalSum = 0;
        int secondaryDiagonalSum = 0;
        int n = arr.Count;

        for (int i = 0; i < n; i++)
        {
            primaryDiagonalSum += arr[i][i];
            secondaryDiagonalSum += arr[i][n - 1 - i];
        }

        return Math.Abs(primaryDiagonalSum - secondaryDiagonalSum);
    } 
} 

class Solution
{
    public static void Main(string[] args)
    {
        
        string outputPath = Environment.GetEnvironmentVariable("OUTPUT_PATH");
        TextWriter textWriter = !string.IsNullOrEmpty(outputPath) 
            ? new StreamWriter(outputPath, true) 
            : Console.Out;

        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<List<int>> arr = new List<List<int>>();

        for (int i = 0; i < n; i++)
        {
            arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
        }

        int result = Result.diagonalDifference(arr);

        textWriter.WriteLine(result);

        if (!string.IsNullOrEmpty(outputPath))
        {
            textWriter.Flush();
            textWriter.Close();
        }
    } 
} 