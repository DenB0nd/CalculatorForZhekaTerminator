namespace CalculatorLibraries.Operators;

public interface IOperator
{
    string Name { get; }
    public IEnumerable<double> Count(IEnumerable<double> values, double value);
}
