CoinChange(5);

// Задание 1
static void CoinChange(int sum)
{
    int[] coins = { 10, 5, 2, 1 };
    int currentCoint = 0;
    int coinSum = 0;

    while (coinSum < sum)
    {
        if (coinSum + coins[currentCoint] > sum)
        {
            currentCoint++;
            continue;
        }

        Console.Write($"{coins[currentCoint]} ");
        coinSum += coins[currentCoint];
    }
}