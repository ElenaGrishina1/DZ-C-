// / Напишите программу, которая выводит третью цифру заданного числа или сообщает,  
// что третьей цифры нет. 
// 645 -> 5 
// 78 -> третьей цифры нет 
// 32679 -> 6


Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num < 1000) 
{
    num = (num % 10);
    Console.WriteLine($"Третья цифра: {num}");
}
else if (num > 999)
{
    while (num >= 999)
    {
        num = num / 10;
    }
    num = (num % 10);
    Console.WriteLine($"Третья цифра: {num}");
}
else
{
    Console.WriteLine("Третьей цифры нет");
}