using System;
// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

Console.Clear();
System.Console.WriteLine();
Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine()); ;

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void PrintResult(int[] array)
{
    int even = 0;
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write(array[i] + " ");
        if (array[i] % 2 == 0) even++;
    }
    System.Console.WriteLine();
    System.Console.WriteLine($" -> {even} Количество четных чисел ");
    System.Console.WriteLine();
}

PrintResult(FillArray(size));