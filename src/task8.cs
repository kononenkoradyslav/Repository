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
    public static int migratoryBirds(List<int> arr)
    {
        int[] birdCounts = new int[6];

        foreach (int bird in arr)
        {
            if (bird >= 1 && bird <= 5)
            {
                birdCounts[bird]++;
            }
        }

        int maxCount = birdCounts[1];
        int mostFrequentBirdId = 1;

        for (int i = 2; i <= 5; i++)
        {
            if (birdCounts[i] > maxCount)
            {
                maxCount = birdCounts[i];
                mostFrequentBirdId = i;
            }
        }

        return mostFrequentBirdId;
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

        string line1 = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(line1))
        {
            line1 = Console.ReadLine();
        }
        int arrCount = Convert.ToInt32(line1.Trim());

        string line2 = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(line2))
        {
            line2 = Console.ReadLine(); 
        }

        List<int> arr = line2
            .Trim()
            .Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(arrTemp => Convert.ToInt32(arrTemp))
            .ToList();

        int result = Result.migratoryBirds(arr);
        textWriter.WriteLine(result);

        textWriter.Flush();
        if (!string.IsNullOrEmpty(outputPath))
        {
            textWriter.Close();
        }
    }
}