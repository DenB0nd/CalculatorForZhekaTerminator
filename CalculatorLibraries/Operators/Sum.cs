namespace CalculatorLibraries.Operators;

public class Sum : IOperator
{
    public string Name => "+";

    public IEnumerable<double> Count(IEnumerable<double> values, double value)
    {
        foreach (var item in values)
        {
            yield return item + value;
        }
    }
}
