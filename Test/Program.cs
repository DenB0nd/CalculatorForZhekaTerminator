
using System.Linq;
using System.Reflection.Emit;
using CalculatorLibraries.History;
using CalculatorLibraries.Operators;

var list = new List<double> { 1, 2, 3, 4, 5};
Div div = new Div();
Mul mul = new Mul();
var res = new List<double>(div.Count(list, 3));
res = new List<double>(mul.Count(res, 3));

res.ForEach(x => Console.WriteLine(x));




