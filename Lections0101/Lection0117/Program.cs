Console.WriteLine("Lection 17/01");

static int GetSum(int[,] numbers)
{
    int sum = 0;                       

    for (int i = 0; i < numbers.GetLength(0); i++)
        for (int j = 0; j < numbers.GetLength(1); j++)
            sum += numbers[i, j];                      

    return sum;                                 
}

static int GetMax(int[] numbers)
{
    int max = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
        if (numbers[i] > max)
            max = numbers[i];
    return max;
}

static int GetMaxElementsSum(int[][] numbers)
{
    int sum = 0;
    for (int i = 1; i < numbers.Length; i++)
        sum += GetMax(numbers[i]);
    return sum;
}
















static int GetElement(int[] numbers, int index)
{
    return numbers[index]; // 0(1)
}

static int GetElement2(int[] numbers, int index)
{
    int element = numbers[index];   // 0(1)
    return numbers[index];          // 0(1)
}


