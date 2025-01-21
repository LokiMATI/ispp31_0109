int[] array = { 7, 0, -4, 3, 1, -2, 5 };

InsertionSort(array);

// Задание 3
static void InsertionSort(int[] array)
{
    int temp;
    for (int i = 1; i < array.Length; i++)
    {
        for (int j = i; j > 0; j--)
            if (array[j] < array[j - 1])
            {
                temp = array[j - 1];
                array[j - 1] = array[j];
                array[j] = temp;
            }
            else
                break;

        foreach (int item in array)
            Console.Write(item + " ");
        Console.WriteLine();
    }
}