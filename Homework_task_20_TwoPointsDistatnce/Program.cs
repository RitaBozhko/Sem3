// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.Write("Введите координаты точки А.\nxa = ");
int xa = int.Parse(Console.ReadLine()!);
Console.Write("ya = ");
int ya = int.Parse(Console.ReadLine()!);
Console.Write("za = ");
int za = int.Parse(Console.ReadLine()!);

Console.Write("Введите координаты точки B.\nxb = ");
int xb = int.Parse(Console.ReadLine()!);
Console.Write("yb = ");
int yb = int.Parse(Console.ReadLine()!);
Console.Write("zb = ");
int zb = int.Parse(Console.ReadLine()!);

double FindDistance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double twoPointsDistance = MathF.Sqrt((x2-x1)*(x2-x1)+(y2-y1)*(y2-y1)+(z2-z1)*(z2-z1));
    return twoPointsDistance;
}

Console.WriteLine($"Расстояние между точками равно {FindDistance(xa, ya, za, xb, yb, zb)}.");