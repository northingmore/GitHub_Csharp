// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату x1");
double x1 = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите координату y1");
double y1 = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите координату z1");
double z1 = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine("Введите координату x2");
double x2 = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите координату y2");
double y2 = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine("Введите координату z2");
double z2 = Convert.ToInt32(Console.ReadLine()!);

Console.WriteLine($"расстояние между ними в 3D пространстве {Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)+Math.Pow(z1-z2,2)):f2}");