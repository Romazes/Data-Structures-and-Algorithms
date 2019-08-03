public static int Fib(int a)
{
    if (a <= 1)
        return a;

    int previous = 0;
    int current = 1;
    for (int i = 2; i <= a; i++)
    {
        int new_current = previous + current;
        previous = current;
        current = new_current;
    }
    return current;
}
