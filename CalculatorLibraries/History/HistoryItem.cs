using CalculatorLibraries.Operators;

namespace CalculatorLibraries.History;

public class HistoryItem
{
    public List<double> Values { get; init; }
    public double Value { get; init; }

    public IOperator Operator { get; init; }

    public HistoryItem(List<double> values, double value, IOperator @operator)
    {
        ArgumentNullException.ThrowIfNull(values, nameof(values));
        ArgumentNullException.ThrowIfNull(@operator, nameof(@operator));
        Values = values;
        Value = value;
        Operator = @operator;
    }

    public override string ToString() => string.Join(", ", Values) + $" {Operator.Name}  {Value} ";
}