using System;
using System.Collections.Generic;
using System.Linq;

class Result
{
    public static int nonDivisibleSubset(int k, List<int> s)
    {
        int[] remainders = new int[k];
        
        foreach (int num in s)
        {
            remainders[num % k]++;
        }
        
        int result = 0;
        
       
        if (remainders[0] > 0)
            result++;
        
        
        if (k % 2 == 0 && remainders[k / 2] > 0)
            result++;
        
        
        for (int i = 1; i < (k + 1) / 2; i++)
        {
            result += Math.Max(remainders[i], remainders[k - i]);
        }
        
        return result;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');
        int n = Convert.ToInt32(firstMultipleInput[0]);
        int k = Convert.ToInt32(firstMultipleInput[1]);
        
        List<int> s = Console.ReadLine().TrimEnd().Split(' ')
            .Select(sTemp => Convert.ToInt32(sTemp))
            .ToList();
        
        int result = Result.nonDivisibleSubset(k, s);
        Console.WriteLine(result);
    }
}
