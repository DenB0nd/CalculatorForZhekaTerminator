namespace CalculatorLibraries.Operators;

public class Root : IOperator
{
    public string Name => "√";
    public IEnumerable<double> Count(IEnumerable<double> values, double value)
    {
        foreach (var item in values)
        {
            yield return Math.Pow(item, 1 / value);
        }
    }
}