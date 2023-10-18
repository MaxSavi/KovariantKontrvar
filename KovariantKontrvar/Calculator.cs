using System;


class Program
{
    public static double Add(double x, double y)
    {
        return x + y;
    }

    public static double Subtract(double x, double y)
    {
        return x - y;
    }

    public static double Multiply(double x, double y)
    {
        return x * y;
    }

    public static double Divide(double x, double y)
    {
        return x / y;
    }

    static void Main(string[] args)
    {
        double x = 10.5;
        double y = 5.5;

        Func<double, double, double> add = Add;
        Func<double, double, double> subtract = Subtract;
        Func<double, double, double> multiply = Multiply;
        Func<double, double, double> divide = Divide;


        double sum = add(x, y);
        Console.WriteLine("Сумма: " + sum);

        double difference = subtract(x, y);
        Console.WriteLine("Разность: " + difference);

        double multiplication = multiply(x, y);
        Console.WriteLine("Произведение: " + multiplication);

        double quotient = divide(x, y);
        Console.WriteLine("Частное: " + quotient);
    }
}
