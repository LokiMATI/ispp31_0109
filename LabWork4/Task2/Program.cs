int[] array = { 1, 3, 7, 5, 8 };

Console.WriteLine(LocalMax(array));

// Задание 2
static int LocalMax(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
        if (array[i] > array[i + 1])
            return array[i];

    return array[array.Length - 1];
}