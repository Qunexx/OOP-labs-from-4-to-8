using System;
using System.Linq;

public class BClass
{
    public int IntValue { get; set; }
    public string StringValue { get; set; }
    public double DoubleValue { get; set; }

    // Переопределение операций true и false
    public static bool operator true(BClass obj)
    {
        return obj.IntValue > 0;
    }

    public static bool operator false(BClass obj)
    {
        return obj.IntValue <= 0;
    }

    // Переопределение операции умножения
    public static BClass operator *(BClass obj1, BClass obj2)
    {
        return new BClass
        {
            IntValue = obj1.IntValue * obj2.IntValue,
            DoubleValue = obj1.DoubleValue * obj2.DoubleValue,
            StringValue = String.Concat(Enumerable.Repeat(obj1.StringValue, obj2.IntValue))
        };
    }

    // Дополнительная операция: вычитание целого параметра
    public static BClass operator -(BClass obj, int value)
    {
        return new BClass
        {
            IntValue = obj.IntValue - value,
            DoubleValue = obj.DoubleValue - value,
            StringValue = obj.StringValue.Substring(0, Math.Max(0, obj.StringValue.Length - value))
        };
    }

    // Дополнительная операция: сложение с параметром-строкой
    public static BClass operator +(BClass obj, string value)
    {
        return new BClass
        {
            IntValue = obj.IntValue,
            DoubleValue = obj.DoubleValue,
            StringValue = obj.StringValue + value
        };
    }

    public override string ToString()
    {
        return $"Int: {IntValue}, String: {StringValue}, Double: {DoubleValue}";
    }
}

class Program
{
    public static void Main(string[] args)
    {
        BClass obj1 = new BClass { IntValue = 5, StringValue = "Hello", DoubleValue = 3.5 };
        BClass obj2 = new BClass { IntValue = 2, StringValue = "World", DoubleValue = 2.0 };

        Console.WriteLine("Исходные данные obj1: " + obj1.ToString() + "\n" + "---------------------");
        BClass multiplied = obj1 * obj2;
        Console.WriteLine("После умножения: " + multiplied.ToString());

        BClass subtracted = obj1 - 3;
        Console.WriteLine("После вычитания: " + subtracted.ToString());

        BClass added = obj1 + " World";
        Console.WriteLine("Дополнительно: " + added.ToString());

        bool obj1True = obj1 ? true : false;
        Console.WriteLine("obj1 - " + (obj1True ? "true" : "false") + "\n" + "---------------------");

        Console.WriteLine("Исходные данные obj2: " + obj2.ToString() + "\n" + "---------------------");
        BClass multiplied1 = obj2 * obj1;
        Console.WriteLine("После умножения: " + multiplied1.ToString());

        BClass subtracted1 = obj2 - 1;
        Console.WriteLine("После вычитания: " + subtracted1.ToString());

        BClass added1 = obj2 + " World";
        Console.WriteLine("Дополнительно: " + added1.ToString());

        bool obj2True = obj2 ? true : false;
        Console.WriteLine("obj2 - " + (obj2True ? "true" : "false"));
    }

}
