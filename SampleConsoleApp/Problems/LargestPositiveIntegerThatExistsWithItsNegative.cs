using System.Linq;

namespace SampleConsoleApp.Problems;

public class LargestPositiveIntegerThatExistsWithItsNegative
{
    public int FindMaxK(int[] nums)
    {

        var negativeNumsSet = nums.Where(num => num < 0).ToHashSet();
        var largestNum = -1;

        foreach (var num in nums.Where(num => num > 0)) 
        {
            if (negativeNumsSet.Contains(-1 * num) && num > largestNum)
                largestNum = num;
        }
        return largestNum;
    }
}
