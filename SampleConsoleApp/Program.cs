using SampleConsoleApp.Problems;
using System.Collections;


public class Program
{
    private class Person
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    public static void Main()
    {
        var bappy = "Bappy";

        var person1 = new Person
        {
            Name = bappy
        };

        var person2 = new Person
        {
            Name = bappy
        };

        bappy = "Pinki";

        Console.WriteLine(person1.ToString());
        Console.WriteLine(person2.ToString());
        Console.WriteLine(bappy.ToString());
    }
}