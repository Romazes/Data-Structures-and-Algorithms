//more efficiency method 

public static int Fib(int value)
{
    int[] array = new int[value + 1];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < array.Length; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
    }
    return array[value];
}
