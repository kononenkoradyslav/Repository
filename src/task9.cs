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
    public static int sockMerchant(int n, List<int> ar)
    {
        HashSet<int> unmatchedSocks = new HashSet<int>();
        int pairsCount = 0;

        foreach (int sock in ar)
        {
            if (unmatchedSocks.Contains(sock))
            {
                pairsCount++;
                unmatchedSocks.Remove(sock);
            }
            else
            {
                unmatchedSocks.Add(sock);
            }
        }

        return pairsCount;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string firstLine = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(firstLine)) return;
        
        int n = Convert.ToInt32(firstLine.Trim());

        string secondLine = Console.ReadLine();
        List<int> ar;

        if (string.IsNullOrWhiteSpace(secondLine))
        {
            ar = new List<int> { 10, 20, 20, 10, 10, 30, 50, 10, 20 };
        }
        else
        {
            ar = secondLine
                .Split(new[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
        }

        int result = Result.sockMerchant(n, ar);
        Console.WriteLine(result);
    }
}