namespace LeetCodeProblems.Easy;

// Given an integer x, return true if x is a palindrome, and false otherwise.
public class PalindromeNumber
{
    // Original string-based approach
    public bool IsPalindrome(int x)
    {
        var xString = x.ToString();
        for (var i = 0; i < xString.Length / 2; i++)
        {
            if (xString[i] != xString[xString.Length - i - 1])
            {
                return false;
            }
        }
        return true;
    }

    public bool IsPalindromeWithNoStrings(int x)
    {
        // Step 1: Handle negative numbers
        if (x < 0)
            return false;  // -121 is not a palindrome

        int original = x;      // Keep original for comparison
        int reversedNum = 0;   // Build reversed number here

        // Step 2: Reverse the number digit by digit
        while (x > 0)
        {
            int lastDigit = x % 10;              // Get rightmost digit
            reversedNum = reversedNum * 10 + lastDigit;  // Add to reversed
            x = x / 10;                          // Remove rightmost digit
        }

        // Step 3: Compare original with reversed
        return original == reversedNum;
    }
}