// Задание 3

int[,] distances = {
 { 0, 10, 15, 20 },
 { 10, 0, 35, 25 },
 { 15, 35, 0, 30 },
 { 20, 25, 30, 0 }
 };

int n = distances.GetLength(0);
int[] visited = new int[n]; // Помечаем посещённые города
int[] path = new int[n]; // Храним маршрут
int currentCity = 0; // Начинаем с города 0
visited[currentCity] = 1; // Отмечаем как посещённый
path[0] = currentCity;

for (int step = 1; step < n; step++)
{
    int nearestCity = -1;
    int minDistance = int.MaxValue;

    for (int i = 0; i < n; i++)
        if (visited[i] == 0 && distances[currentCity, i] < minDistance)
        {
            minDistance = distances[currentCity, i];
            nearestCity = i;
        }

    visited[nearestCity] = 1; // Помечаем город как посещённый
    path[step] = nearestCity; // Добавляем в маршрут
    currentCity = nearestCity; // Переходим в новый город
}

// Вывод результата
Console.WriteLine("Приближённый маршрут:");
for (int i = 0; i < n; i++)
    Console.Write(path[i] + (i < n - 1 ? "->" : ""));