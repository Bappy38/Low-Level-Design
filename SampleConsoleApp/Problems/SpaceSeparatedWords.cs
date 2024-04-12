namespace SampleConsoleApp.Problems;

public class SpaceSeparatedWords
{
    public static int GetLengthOfLastWord(string s)
    {
        var words = s.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        var lastWord = words.Last();
        return lastWord.Length;
    }
}
