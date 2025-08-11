namespace LeetCodeProblems.Easy;

public class ValidParentheses {
    public bool IsValid(string s)
    {
        Stack<char> stack = new Stack<char>();
        Dictionary<char, char> parenthesesMap =
            new Dictionary<char, char>() { { '(', ')' }, { '{', '}' }, { '[', ']' } };

        foreach (char c in s)
        {
            if (parenthesesMap.ContainsKey(c))
            {
                stack.Push(c);
            }
            else if (parenthesesMap.ContainsValue(c))
            {
                if (stack.Count == 0 || parenthesesMap[stack.Pop()] != c)
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }
}