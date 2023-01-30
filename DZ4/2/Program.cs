// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
Console.Clear();
Console.Write("Введите число: ");
int numN = Convert.ToInt32(Console.ReadLine());

static int GetSum(int num)
{
    int res = 0;
    for(int i = 1; i <= num; i++)
    {
        res += num % 10;
        num /= 10;
    }
    return res;
}
Console.WriteLine(GetSum(numN));
