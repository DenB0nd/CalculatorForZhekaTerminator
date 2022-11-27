namespace CalculatorLibraries.Operators;

public class Pow : IOperator
{
    public string Name => "^";
    public IEnumerable<double> Count(IEnumerable<double> values, double value)
    {
        foreach (var item in values)
        {
            yield return Math.Pow(item, value);
        }
    }
}
