using System.Runtime.InteropServices;

namespace SampleConsoleApp.Problems;

public class IsomorphicString
{
    public static bool IsIsomorphic(string s, string t)
    {
        var charToCharMap = new Dictionary<char, char>();
        var usedChar = new HashSet<char>();

        for (int i = 0; i < s.Length; i++)
        {
            char charOfS = s[i];
            char charOfT = t[i];

            if (AppropriateMap(charOfS, charOfT, charToCharMap))
            {
                continue;
            }

            if (InAppropriateMap(charOfS, charOfT, charToCharMap)) 
            {
                return false;
            }
            else if (!TryMap(charOfS, charOfT, charToCharMap, usedChar))
            {
                return false;
            }
        }

        return true;
    }

    private static bool AppropriateMap(char charOfS, char charOfT, Dictionary<char, char> charToCharMap)
    {
        return charToCharMap.ContainsKey(charOfS) && charToCharMap[charOfS] == charOfT;
    }

    private static bool InAppropriateMap(char charOfS, char charOfT, Dictionary<char, char> charToCharMap)
    {
        return charToCharMap.ContainsKey(charOfS) && charToCharMap[charOfS] != charOfT;
    }

    private static bool TryMap(char charOfS, char charOfT, Dictionary<char, char> charToCharMap, HashSet<char> usedChar)
    {
        if (usedChar.Contains(charOfT))
        {
            return false;
        }

        usedChar.Add(charOfT);
        charToCharMap[charOfS] = charOfT;
        return true;
    }
}
