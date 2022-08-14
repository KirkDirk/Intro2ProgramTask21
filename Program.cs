// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53
Console.Clear();
int[] arr1point = new int[3];
int[] arr2point = new int[3];
Console.WriteLine("Введите координату Х первой точки: ");
arr1point[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки: ");
arr1point[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z первой точки: ");
arr1point[2] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Х первой точки: ");
arr2point[0] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y первой точки: ");
arr2point[1] = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Z первой точки: ");
arr2point[2] = Convert.ToInt32(Console.ReadLine());

double quadre = 0;
for (int i = 0; i < 3; i++)
{
    quadre = quadre + Math.Pow((arr1point[i] - arr2point[i]),2);
}
double dist = Math.Sqrt(quadre);
Console.WriteLine($"Расстояние между двумя точками = {Math.Round(dist, 2)}");

