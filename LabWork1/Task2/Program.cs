int[] array = { 7, 0, -4, 3, 1, -2, 5 };

BubbleSort(array);

// Задание 2
static void BubbleSort(int[] array)
{
    int temp;
    bool isChange;
    do
    {
        isChange = false;
        for (int i = array.Length - 1; i > 0; i--)
            if (array[i] < array[i - 1])
            {
                isChange = true;
                temp = array[i];
                array[i] = array[i - 1];
                array[i - 1] = temp;
            }

        foreach (int item in array)
            Console.Write($"{item} ");
        Console.WriteLine();
    } while (isChange);
}