namespace SampleConsoleApp.Problems;

public class ValidParenthesisWithStack
{
    public static bool isValidParenthesis(string s)
    {
        var openParIdxs = new Stack<int>();
        var dummyParIdxs = new Stack<int>();

        for (var idx = 0 ; idx < s.Length; idx++)
        {
            var parenthesis = s[idx];

            if (parenthesis == '(')
            {
                openParIdxs.Push(idx);
            }
            else if (parenthesis == '*')
            {
                dummyParIdxs.Push(idx);
            }
            else if (!TryRemoveCorrespondingOpenPar(openParIdxs, dummyParIdxs))
            {
                return false;
            }
        }

        return TryRemoveRemainingOpenPars(openParIdxs, dummyParIdxs);
    }

    private static bool TryRemoveRemainingOpenPars(Stack<int> openParIdxs, Stack<int> dummyParIdxs)
    {
        while (openParIdxs.Any())
        {
            if (!dummyParIdxs.Any() || dummyParIdxs.Pop() < openParIdxs.Pop())
            {
                return false;
            }
        }
        return true;
    }

    private static bool TryRemoveCorrespondingOpenPar(Stack<int> openParIdxs, Stack<int> dummyParIdxs)
    {
        if (!openParIdxs.Any() && !dummyParIdxs.Any())
        {
            return false;
        }

        var correspondingOpenParIdx = openParIdxs.Any() ? openParIdxs.Pop() : dummyParIdxs.Pop();
        return true;
    }
}
