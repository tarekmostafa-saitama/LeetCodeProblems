namespace LeetCodeProblems.Easy;

public class RomanToInteger {
    public int RomanToInt(string s)
    {
        // Create a dictionary to map Roman numerals to their integer values
        Dictionary<char, int> romanMap = new Dictionary<char, int>()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };
        int result = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (i + 1 < s.Length && romanMap[s[i]] < romanMap[s[i + 1]])
            {
                result -= romanMap[s[i]];
            }
            else
            {
                result += romanMap[s[i]];
            }
        }

        return result;
    }
}