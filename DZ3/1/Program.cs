// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

//Только для пятизначного числа
// Console.Write("Введите число: ");
// string num = Console.ReadLine();

// if (num[0] == num[4] && num[1] == num[3])
// {
//     System.Console.WriteLine("Является палиндромом");
// }
// else
// {
//     System.Console.WriteLine("Не является палиндромом");
// }

// Для n_значного чисел
System.Console.Write("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());

int num1 = num;
int num2 = 0;
int num3;
while (num > 0)
{
    num3 = num % 10;
    num2 = num2 * 10 + num3;
    num = num / 10;
}

if (num1 == num2)
{
    Console.WriteLine("палиндром");
}
else
{
    Console.WriteLine("не палиндром");
}