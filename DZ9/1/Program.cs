// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear(); 
Console.WriteLine("Введите первое число"); 
int a = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите второе число"); 
int b = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine(PrintNumbers(a, b)); 


string PrintNumbers(int end, int start) 
{ 
    if (end == start) 
    { 
        return end.ToString();
        
    } 
    if (end < start)
    {
      (end, start) = (start, end);  
    }

    return (end + " " + PrintNumbers(end - 1, start)); 
}