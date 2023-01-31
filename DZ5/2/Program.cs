// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Clear();

int size = 4;

int[] array = FillArray(size);
PrintArray(array);
Console.WriteLine();
System.Console.WriteLine($"Сумма чисел, стоящих на нечетной позиции, соcтаваляет {SumArray(array)} ");

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 999);
    return (array);
}

int SumArray(int[] array)
{
    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + " ");
        if (i % 2 > 0) sum += array[i];
    }
    return sum;
}

void PrintArray(int[] array)
{
    int i;
    Console.Write("[");

    for (i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}, ");
    Console.Write("]");
}
