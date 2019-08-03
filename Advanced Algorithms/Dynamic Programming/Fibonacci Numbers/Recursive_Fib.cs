// the most simple example of Fibonacci Numbers

public static int Fib1(int value)
{
    return value == 0 ? 0 : value == 1 ? 1 : Fib1(value - 1) + Fib1(value - 2);
}
