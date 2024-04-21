using System.Collections;

namespace SampleConsoleApp.Problems;

public class Person
{
    public static string Name;

    static Person()
    {
        Name = "Bappy";
    }
}

public class Employee : Person
{
    public static string Department;

    static Employee()
    {
        Department = $"CSE";
    }
}