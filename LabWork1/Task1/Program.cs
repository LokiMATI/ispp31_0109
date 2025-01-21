int[] array = { 7, 0, -4, 3, 1, -2, 5 };

SelectionSort(array);

// Задание 1
static void SelectionSort(int[] array)
{
    int temp, minIndex;
    for (int i = 0; i < array.Length; i++)
    {
        minIndex = i;
        for (int j = i + 1; j < array.Length; j++)
            if (array[minIndex] > array[j])
                minIndex = j;

        if (minIndex != i)
        {
            temp = array[i];
            array[i] = array[minIndex];
            array[minIndex] = temp;
        }

        foreach (int item in array)
            Console.Write(item + " ");
        Console.WriteLine();
    }
}