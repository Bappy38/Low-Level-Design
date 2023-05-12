using Strategy_Pattern.Strategies;

namespace Strategy_Pattern.Context;

public class SalaryCalculator
{
	// The Context maintains a reference to one of the Strategy objects.
	// The Context does not know the concrete class of a strategy.
	// It should work with all strategies via the Strategy interface.

    private ISalaryCalculator _calculator;


	// Usually, the Context accept a Strategy through the Constructor.
	// But, also provides a setter to change it at runtime.
	public SalaryCalculator(ISalaryCalculator calculator)
	{
		_calculator = calculator;
	}

	// Usually, the Context allows replacing a Strategy object at runtime.
	public void SetCalculator(ISalaryCalculator calculator)
	{
		_calculator = calculator;
	}

	// The Context delegates some work to the Strategy object instead of
	// implementing multiple versions of the algorithm on its own.
	public double Calculate(List<DeveloperReport> reports)
	{
		return _calculator.CalculateTotalSalary(reports);
	}
}
