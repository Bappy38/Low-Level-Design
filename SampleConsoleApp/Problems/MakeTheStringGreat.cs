using System.Text;

namespace SampleConsoleApp.Problems;

public class MakeTheStringGreat
{
    public static string MakeGood(string s)
    {
        var goodChars = new Stack<char>();

        foreach (char ch in s)
        {
            if (IsBadPair(goodChars.FirstOrDefault(), ch))
            {
                goodChars.Pop();
            }
            else
            {
                goodChars.Push(ch);
            }
        }

        var greatString = new StringBuilder();
        foreach (char ch in goodChars.Reverse())
        {
            greatString.Append(ch);
        }
        return greatString.ToString();
    }

    private static bool IsBadPair(char ch1, char ch2)
    {
        if (ch1 is '\0' || ch2 is '\0')
        {
            return false;
        }

        if (ch1 > ch2)
        {
            //SWAP value with tuple
            (ch2, ch1) = (ch1, ch2);
        }

        return ch1 + 32 == ch2;
    }
}
