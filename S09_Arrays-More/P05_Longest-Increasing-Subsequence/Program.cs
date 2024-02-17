using System;
using System.Collections.Generic;
using System.Linq;

class MainClass
{
    public static void Main(string[] args)
    {
        int[] nums = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

        // Calculating Longest Increasing Subsequence (LIS) with Previous
        int[] size = new int[nums.Length];
        int[] parent = new int[nums.Length];
        int bestLen = 0, bestIdx = 0;
        for (int currIdx = 0; currIdx < nums.Length; currIdx++)
        {
            int currNum = nums[currIdx];
            int currLen = 1;
            int currParent = -1;
            for (int prevIdx = currIdx - 1; prevIdx >= 0; prevIdx--)
            {
                int prevNumber = nums[prevIdx];
                int prevLen = size[prevIdx];

                if (prevNumber >= currNum)
                    continue;

                if (prevLen + 1 >= currLen)
                {
                    currLen = prevLen + 1;
                    currParent = prevIdx;
                }
            }
            size[currIdx] = currLen;
            parent[currIdx] = currParent;
            if (currLen > bestLen)
            {
                bestLen = currLen;
                bestIdx = currIdx;
            }
        }

        // Restoring LIS Elements
        List<int> result = new List<int>();
        int idx = bestIdx;
        while (idx != -1)
        {
            result.Insert(0, nums[idx]);
            idx = parent[idx];
        }
        Console.WriteLine(string.Join(" ", result));
    }
}
