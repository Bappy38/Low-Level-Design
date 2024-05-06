public class Solution
{
    public int NumRescueBoats(int[] people, int limit)
    {

        var i = 0;
        var j = people.Count() - 1;
        var numOfRequiredBoats = 0;

        Array.Sort(people);
        while (i <= j)
        {

            numOfRequiredBoats++;
            if (people[i] + people[j] <= limit)
            {

                i++;
            }
            j--;
        }

        return numOfRequiredBoats;
    }
}