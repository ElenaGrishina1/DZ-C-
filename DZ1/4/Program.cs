// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

 System.Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;
if (number == 1)
{
    Console.WriteLine ("Нет четных чисел");
}
else
{
    Console.WriteLine ($"Все четные числа до {number}");
while (count < (number -1))
    {
    count = count +2;
    Console.WriteLine (count);
    }
}