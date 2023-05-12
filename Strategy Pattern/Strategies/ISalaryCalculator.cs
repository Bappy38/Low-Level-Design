namespace Strategy_Pattern.Strategies;

/// <summary>
/// The Strategy interface declares operations common to all supported versions algorithm.
/// 
/// The Context uses this interface to call the algorithm defined by Concrete Strategies.
/// </summary>


public interface ISalaryCalculator
{
    double CalculateTotalSalary(List<DeveloperReport> reports);
}
