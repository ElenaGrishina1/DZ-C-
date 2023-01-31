// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.Clear();
System.Console.WriteLine();

int size = new Random().Next(1, 11);
double[] array = FillArray(size);
System.Console.WriteLine($"Количетсов элементов массива: {size}");
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Минимальное значение массива {array.Min()}, максимальное значение массива {array.Max()}");
System.Console.WriteLine($"Разница между минимальным и максимальным значениями массива составляет {DiffMinMax(array)}");
System.Console.WriteLine();

double[] FillArray(int size)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() * 100;
    }
    return array;
}

void PrintArray(double[] array)
{
    int i;
    Console.Write("[");

    for (i = 0; i < array.Length; i++)
        Console.Write($"{array[i]}, ");
    Console.Write("]");
}

double DiffMinMax(double[] arr)
{
    double difference = arr.Max() - arr.Min();
    return difference;
}
