int[] array = { 100, 1, 2, 3, 4, 5, 6, 7 };

Console.WriteLine(LinearSearch(array, 2));
Console.WriteLine(LinearSearch(array, -123));

// Задание 1
static int LinearSearch(int[] array, int item)
{
    for (int i = 0; i < array.Length; i++)
        if (array[i] == item) 
            return i;
    return -1;
}