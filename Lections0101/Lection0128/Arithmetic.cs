

// overload


public class Arithmetic
{
    public static int Sum(int a, int b) => a + b;
    public static double Sum(double a, int b) => a + b;
    public static int Sum(int a, int b, int c) => a + b + c;

    public static int Add(int a, int b = 1) => a + b;
    public static int Substract(int a, int b) => a - b;
}
