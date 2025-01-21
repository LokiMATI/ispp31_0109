int[] array = { 1, 2, 3, 4, 5, 6, 7 };

Console.WriteLine(BinarySearch(array, 6));

// Задание 2
static int BinarySearch(int[] array, int item)
{
    int left = 0, right = array.Length - 1, middle;
    do
    {
        middle = (right - left) / 2 + left;
        if (array[middle] == item)
            return middle;

        if (array[middle] > item)
            right = middle - 1;
        else
            left = middle + 1;
    } while (left < right);
    return -1;
}