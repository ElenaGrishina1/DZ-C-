// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int[] CreateArray(int size)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1}-е число: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}
int Count(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0) count++;
    return (count);
}
Console.Write("Введите число М: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] myArray = CreateArray(n);
PrintArray(myArray);
Console.WriteLine($"Количество чисел больше 0 = {Count(myArray)}");
