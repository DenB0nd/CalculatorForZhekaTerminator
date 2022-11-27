namespace CalculatorLibraries.Operators;

public class Log : IOperator
{
    public string Name => "log";
    public IEnumerable<double> Count(IEnumerable<double> values, double value)
    {
        foreach (var item in values)
        {
            yield return Math.Log(item, value);
        }
    }
}
