namespace Strategy_Pattern.Strategies;


/// <summary>
/// Concrete Strategies implement the algorithm while following the base Strategy interface. The interface makes them interchangeable in the Context.
/// </summary>


public class JuniorDeveloperSalaryCalculator : ISalaryCalculator
{
    public double CalculateTotalSalary(List<DeveloperReport> reports)
    {
        return reports
            .Where(r => r.Level == DeveloperLevel.Junior)
            .Select(r => r.CalculateSalary())
            .Sum();
    }
}
