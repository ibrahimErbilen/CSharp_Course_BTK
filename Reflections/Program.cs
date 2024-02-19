using System.Reflection;

var type = typeof(MathOperators);

MathOperators mathOperators = (MathOperators)Activator.CreateInstance(type, 6, 7)!;

Console.WriteLine($"{mathOperators.Add(4, 5)}");
Console.WriteLine($"{mathOperators.Add2()}");

var instance = Activator.CreateInstance(type, 1, 2);

MethodInfo methodInfo = instance!.GetType().GetMethod("Add2")!;

Console.WriteLine($"Result: {methodInfo.Invoke(instance, null)}");


var methods = type.GetMethods();

Console.WriteLine($"--------------");
foreach (var info in methods)
{
    Console.WriteLine($"Method Name: {info.Name}");
    foreach (var parameter in info.GetParameters())
    {
        Console.WriteLine($"Parameter Name: {parameter.Name}");
    }
    foreach (var attribute in info.GetCustomAttributes())
    {
        Console.WriteLine($"Attribute: {attribute.GetType().Name}");
    }
    Console.WriteLine($"");
}


public class MathOperators
{
    private int _number1;
    private int _number2;

    public MathOperators(int number1, int number2)
    {
        _number1 = number1;
        _number2 = number2;
    }

    public MathOperators()
    {

    }
    public int Add(int number1, int number2)
    {
        return number1 + number2;
    }

    public int Multiply(int number1, int number2)
    {
        return number1 * number2;
    }

    public int Add2()
    {
        return _number1 + _number2;
    }

    [MethodName("Multiplies")]
    public int Multiply2()
    {
        return _number1 * _number2;
    }
}

public class MethodNameAttribute : Attribute
{
    public MethodNameAttribute(String name)
    {

    }
}
