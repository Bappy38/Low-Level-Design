using System.Text;

namespace SampleConsoleApp.Problems;

public class MinRemoveToMakeValidParenthesis
{
    public static string MinRemoveToMakeValid(string s)
    {
        var indexesNeedToRemove = GetMinIndexesNeedToRemove(s);

        var longestValidParenthesis = new StringBuilder();

        for (var idx = 0; idx < s.Length; idx++)
        {
            if (indexesNeedToRemove.Contains(idx))
            {
                continue;
            }
            longestValidParenthesis.Append(s[idx]);
        }
        return longestValidParenthesis.ToString();
    }

    private static HashSet<int> GetMinIndexesNeedToRemove(string s)
    {
        var openParIdxs = new Stack<int>();
        var removedIdxs = new HashSet<int>();

        for (var idx = 0; idx < s.Length; idx++)
        {
            if (IsAlphabet(s[idx]))
            {
                continue;
            }

            if (IsOpenParenthesis(s[idx]))
            {
                openParIdxs.Push(idx);
                continue;
            }

            if (HasCorrespondingOpenPar(openParIdxs))
            {
                openParIdxs.Pop();
            }
            else
            {
                removedIdxs.Add(idx);
            }
        }

        while (openParIdxs.Count > 0)
        {
            removedIdxs.Add(openParIdxs.Pop());
        }

        return removedIdxs;
    }

    private static bool HasCorrespondingOpenPar(Stack<int> openParIdxs)
    {
        return openParIdxs.Count > 0;
    }

    private static bool IsOpenParenthesis(char ch)
    {
        return ch == '(';
    }

    private static bool IsAlphabet(char ch)
    {
        return (ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z');
    }
}
