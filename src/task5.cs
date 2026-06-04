using System;
using System.Linq;

class Result
{
    public static string kangaroo(int x1, int v1, int x2, int v2)
    {
        if (v1 > v2 && (x2 - x1) % (v1 - v2) == 0)
        {
            return "YES";
        }
        return "NO";
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(input)) return;

        string[] firstMultipleInput = input.TrimEnd().Split(' ');

        int x1 = Convert.ToInt32(firstMultipleInput[0]);
        int v1 = Convert.ToInt32(firstMultipleInput[1]);
        int x2 = Convert.ToInt32(firstMultipleInput[2]);
        int v2 = Convert.ToInt32(firstMultipleInput[3]);

        string result = Result.kangaroo(x1, v1, x2, v2);

        Console.WriteLine($"{result}");
    }
}