using System;
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Clear();
System.Console.WriteLine();
Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine()); ;
int[] array = FillArray(size);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($"Количество чётных чисел в массиве: {CountNumber(array)}");

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 999);
    return (array);
}

int CountNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            count++;
    return count;
}

void PrintArray(int[] array)
{
    int i;
    Console.Write("[");

    for (i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}, ");
    Console.Write("]");
}
