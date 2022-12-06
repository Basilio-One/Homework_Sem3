// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.WriteLine("Введите число N ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Квадрат чисел равен: ");

if (N<0) N=-N;
else if (N==0) Console.WriteLine("0");
for (int i = 1; i <= N; i++)
{
    int sqrt = (i * i * i);
    Console.Write($"{sqrt} ");
}