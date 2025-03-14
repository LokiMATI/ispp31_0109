// Задание 1
using Task1;

int num1 = 3, num2 = 2;

Context context = new(new OperationAdd());
Console.WriteLine($"OpearationAdd: {context.ExecuteStrategy(num1, num2)}");

context = new(new OperationSubstract());
Console.WriteLine($"OperationSubstract: {context.ExecuteStrategy(num1, num2)}");

context = new(new OperationMultiply());
Console.WriteLine($"OperationMultiply: {context.ExecuteStrategy(num1, num2)}");

context = new(new OperationDivide());
Console.WriteLine($"OperationDivision: {context.ExecuteStrategy(num1, num2)}");