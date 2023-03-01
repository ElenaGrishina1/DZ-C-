// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше или равна 3 символа.

Console.Clear();
string[] array = { "hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Russia", "Denmark", "Kazan" };
string[] newArray = new string[array.Length];
string[] ArrayLessThree(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        string str = array[i];
		
		if (str.Length <= 3)
        {
            newArray[count] = str;
            count++;
        }
    }
	return newArray;
}


Console.WriteLine("Исходный массив: ");
PrintArray(array);
ArrayLessThree(array);
Console.WriteLine("Полученный массив: ");
PrintArray(newArray);