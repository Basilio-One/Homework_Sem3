// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите первую координату в точке А");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату в точке А");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью координату в точке А");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите первую координату в точке B");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите вторую координату в точке B");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третью координату в точке B");
int z2 = Convert.ToInt32(Console.ReadLine());

double lenght = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2)+ Math.Pow((z2-z1),2));

Console.Write(" Расстояния между точками в 3D пространстве: ");
Math.Round(lenght,2);
Console.WriteLine(Math.Round(lenght,2));