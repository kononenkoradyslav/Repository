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
    public static List<int> breakingRecords(List<int> scores)
    {
        if (scores == null || scores.Count == 0)
        {
            return new List<int> { 0, 0 };
        }

        int highestScore = scores[0];
        int lowestScore = scores[0];

        int maxBreaks = 0;
        int minBreaks = 0;

        for (int i = 1; i < scores.Count; i++)
        {
            if (scores[i] > highestScore)
            {
                highestScore = scores[i];
                maxBreaks++;
            }
            else if (scores[i] < lowestScore)
            {
                lowestScore = scores[i];
                minBreaks++;
            }
        }

        return new List<int> { maxBreaks, minBreaks };
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string linesCountInput = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(linesCountInput)) return;

        string scoresInput = Console.ReadLine();
        while (string.IsNullOrWhiteSpace(scoresInput))
        {
            scoresInput = Console.ReadLine();
            if (scoresInput == null) return;
        }

        List<int> scores = scoresInput.TrimEnd().Split(' ').Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

        List<int> result = Result.breakingRecords(scores);

        Console.WriteLine(String.Join(" ", result));
    }
}