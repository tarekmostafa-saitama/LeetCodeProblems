using System;
using System.Collections.Generic;


// Given an array of integers nums and an integer target, return indices of the two numbers such
// that they add up to target.
// You may assume that each input would have exactly one solution, and you may not use the same element twice.
// You can return the answer in any order.
public class TwoSum
{
    // O(n²) Time Complexity - Brute Force Approach
    // O(1) Space Complexity
    public int[] TwoSumBruteForce(int[] nums, int target)
    {
        // Check every pair of numbers
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target)
                {
                    return new int[] { i, j };
                }
            }
        }
        return new int[] { }; // No solution found
    }

    // O(n) Time Complexity - Hash Map Approach
    // O(n) Space Complexity
    public int[] TwoSumOptimized(int[] nums, int target)
    {
        // Dictionary to store: number -> index
        Dictionary<int, int> numToIndex = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int current = nums[i];
            int needed = target - current;

            // Check if the complement exists in our dictionary
            if (numToIndex.ContainsKey(needed))
            {
                // Found the pair! Return indices
                return new int[] { numToIndex[needed], i };
            }

            // Store current number and its index for future lookups
            // Note: We store after checking to avoid using the same element twice
            numToIndex[current] = i;
        }

        return new int[] { }; // No solution found
    }
}