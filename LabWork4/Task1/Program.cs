CoinChange(6);

// Задание 1
static void CoinChange(int sum)
{
    int[] coins = { 1, 3, 4 };
    Array.Sort(coins);
    int currentCoin = coins.Length - 1;
    int coinSum = 0;

    while (coinSum < sum)
    {
        if (coinSum + coins[currentCoin] > sum)
        {
            currentCoin--;
            continue;
        }

        Console.Write($"{coins[currentCoin]} ");
        coinSum += coins[currentCoin];
    }
}