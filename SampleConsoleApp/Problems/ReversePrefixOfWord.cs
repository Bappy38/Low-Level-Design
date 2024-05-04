using System.Text;

namespace SampleConsoleApp.Problems;

public class ReversePrefixOfWord
{
    /**
     * Note: string in C# is read only. We can't change like this s[i] = 'a'
    **/
    public static string ReversePrefix(string word, char seperator)
    {
        var idxOfFirstOccur = word.IndexOf(seperator);

        var result = new StringBuilder();
        for (int idx = idxOfFirstOccur; idx >= 0; idx--)
        {
            result.Append(word[idx]);
        }

        var suffix = word[(idxOfFirstOccur + 1)..];
        result.Append(suffix);

        return result.ToString();
    }
}
