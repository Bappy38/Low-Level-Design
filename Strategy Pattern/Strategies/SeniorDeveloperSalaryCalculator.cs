namespace Strategy_Pattern.Strategies;

public class SeniorDeveloperSalaryCalculator : ISalaryCalculator
{
    public double CalculateTotalSalary(List<DeveloperReport> reports)
    {
        return reports
            .Where(r => r.Level == DeveloperLevel.Senior)
            .Select(r => r.CalculateSalary() * 1.2)
            .Sum();
    }
}
