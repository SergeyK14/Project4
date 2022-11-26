//Задача 21: Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.

void Rasstin3D()
{
Console.WriteLine ($"Введите координаты точки A");
Console.Write ("x1 = ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write ("y1 = ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write ("z1 = ");
double z1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ($"Введите координаты точки B");
Console.Write ("x2 = ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write ("y2 = ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write ("z2 = ");
double z2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine ($"Координаты точки A ({x1}; {y1}; {z1})");
Console.WriteLine ($"Координаты точки B ({x2}; {y2}; {z2})");
double rasst = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine ("Расстояние между точками А и В в 3D-пространстве равно: " + Math.Round((rasst), 4));
}
Rasstin3D();