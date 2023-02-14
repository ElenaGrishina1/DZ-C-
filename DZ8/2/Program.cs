// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();
int[,] matrix = new int[3, 4];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
Console.WriteLine("Cтрока с наименьшей суммой элементов: " + Sum(matrix));
void FillArray(int[,] matr)
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            matr[m, n] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            Console.Write($"{matr[m, n]} ");
        }
        Console.WriteLine();
    }
}

int Sum(int[,] matr)
{
    int sum = 0;
    int minSum = 0;
    int minNum = 0;
    for (int m = 0; m < matr.GetLength(0); m++)
    {
        for (int n = 0; n < matr.GetLength(1); n++)
        {
            if (m == 0) 
            {
                sum += matr[m, n];
                minSum += matr[m, n]; 
            }
            else sum += matr[m, n]; 
        }
        if (sum < minSum)
        {
            minSum = sum;
            minNum = m;
        }
        sum = 0;
    }
    return minNum;
}


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.

// int[,] CreateMatrixRndInt (int rows, int columns, int min, int max)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rnd = new Random();

//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix[i, j] = rnd.Next(min, max + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//     Console.Write("|");
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//     if (j < matrix.GetLength(1) -1) Console.Write($"{matrix[i, j], 4}, ");
//     else Console.Write($"{matrix[i, j], 4} ");
//     }
//     Console.WriteLine("|");
//     }
// }

// int[] SumInRows(int[,] matrix)
// {
//     int[] sumElementsOfRows = new int[matrix.GetLength(0)];
//     int sum = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             sum = sum + matrix[i,j];
//             sumElementsOfRows[i] = sum;
//             }
//     // sum = 0;
//     }
//     return sumElementsOfRows;
// }

// void PrintArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i < array.Length - 1) Console.WriteLine($"{array[i]}; ");
//         else Console.WriteLine($"{array[i]}");
//     }
// }

// int TheSmallestSum (int[] array)
// {

// int indexRow = 0;
// int minSum = array[indexRow];

// for (int i = 0; i < array.Length; i++)
// {
//      if (array[i] < array[indexRow]) minSum = array[i]; indexRow = i;

// }
// return (indexRow);
// }

// int[,] array2D = CreateMatrixRndInt(4, 4, 1, 9);
// PrintMatrix(array2D);
// Console.WriteLine();
// int[] sumElementsOfRows = SumInRows(array2D);
// PrintArray(sumElementsOfRows);
// Console.WriteLine();
// int indexRow = TheSmallestSum(sumElementsOfRows);
// Console.WriteLine($"Строка с наименьшей суммой элементов массива --> {indexRow}");