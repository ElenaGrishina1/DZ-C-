// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Clear();
int m = 4;
int n = 4;
SpiralFillMatrix(m, n);

void SpiralFillMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    int count = 1;
    int t = 0;  //сдвиг от края матрицы после первого прохода по периметру
    int i = 0;
    int j = 0;
    do
    {
        if (count > m * n) break;
        for (i = t; i < n - t; i++)     // движение вправо
            matrix[t, i] = count++;
        if (count > m * n) break;
        for (j = 1 + t; j < m - t; j++)   // движение вниз  
            matrix[j, n - 1 - t] = count++;
        if (count > m * n) break;
        for (i = n - 2 - t; i >= t; i--)  // движение влево  
            matrix[m - 1 - t, i] = count++;
        if (count > m * n) break;
        for (j = m - 2 - t; j > t; j--)   // движение вверх  
            matrix[j, t] = count++;
        t++;

    } while (count <= m * n);
    Console.WriteLine();
    for (i = 0; i < m; i++)
    {
        for (j = 0; j < n; j++)
            if (matrix[i, j] / 10 <= 0)
                Console.Write($" {matrix[i, j]} ");
            else Console.Write($"{matrix[i, j]} ");
        Console.WriteLine();
    }
}
