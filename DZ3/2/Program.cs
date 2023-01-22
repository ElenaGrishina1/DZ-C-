// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

//Random rnd = new Random();
//int x1 = rnd.Next(-10, 11);
//int y1 = rnd.Next(-10, 11);
//int z1 = rnd.Next(-10, 11);
//int x2 = rnd.Next(-10, 11);
//int y2 = rnd.Next(-10, 11);
//int z2 = rnd.Next(-10, 11);
Console.Write("Введите координату X первой точки: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y первой точки: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X первой точки: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату X второй точки: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y второй точки: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z второй точки: ");
int z2 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"x1 {x1}, y1 {y1}, z1 {z1}, x2 {x2}, y2 {y2}, z2 {z2}");

double result = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));

System.Console.WriteLine(result);