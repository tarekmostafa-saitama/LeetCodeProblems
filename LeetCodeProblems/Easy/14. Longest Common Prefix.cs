namespace LeetCodeProblems.Easy;

public class LongestCommonPrefixString {
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0) return "";
        string shortedString = strs.MinBy(x => x.Length);
        string prefix = "";
        for (int i = 0; i < shortedString.Length; i++)
        {
            bool allMatch = strs.All(x => x[i] == shortedString[i]);
            if (allMatch)
            {
                prefix += shortedString[i];
            }
            else
            {
                break;
            }
        }
        return prefix;
    }
}