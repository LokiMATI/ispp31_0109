int[] array = { 1, 2, 3, 4, 5, 6, 7, 8};

Console.WriteLine(JumpSearch(array, 0));
Console.WriteLine(JumpSearch(array, 1));
Console.WriteLine(JumpSearch(array, 7));
Console.WriteLine(JumpSearch(array, 8));

// Задание 3
static int JumpSearch(int[] array, int item)
{
    int previousStep = 0;
    int jumpStep = (int)Math.Sqrt(array.Length);
    int nextStep = jumpStep;

    if (array[array.Length - 1] < item)
        return -1;

    while (array[nextStep] < item)
    {
        previousStep = nextStep;
        nextStep += jumpStep;

        if (nextStep > array.Length - 1)
        {
            for (int i = previousStep; i <= array.Length; i++)
                if (array[i] == item)
                    return i;
            return -1;
        }            
    }

    for (int i = previousStep; i <= previousStep + jumpStep; i++)
        if (array[i] == item)
            return i;

    return -1;
}