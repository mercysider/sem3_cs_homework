// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координату X точки A:");
int X1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y точки A:");
int Y1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Z точки A:");
int Z1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату X точки B:");
int X2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y точки B:");
int Y2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите координату Y точки B:");
int Z2 = int.Parse(Console.ReadLine()!);

double divX = Math.Pow(X2 - X1, 2);
double divY = Math.Pow(Y2 - Y1, 2);
double divZ = Math.Pow(Z2 - Z1, 2);

double d = Math.Round(Math.Sqrt(divX + divY + divZ), 2);

Console.WriteLine($"Расстояние между точками A ({X1},{Y1},{Z1}) и B ({X2},{Y2},{Z2}) в 3D-пространстве = {d}");