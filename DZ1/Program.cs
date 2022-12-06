// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом. Через строку решать нельзя.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

try
{
    Console.WriteLine("Введите пятизначное число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int x1 = num/10000;
    int x2 = num%10000/1000;
    int x3 = num%100/10;
    int x4 = num%10;
    int x5 = num/100%10;
    CheckKord(x1, x2, x3, x4, x5, num);
}
catch
{
    Console.WriteLine("Нужно вводить целые числа");
}

void CheckKord (int x1, int x2, int x3, int x4, int x5, int num)
{
    if (x1==x4 && x2==x3) Console.WriteLine($"{num} -> {x1}{x2}{x5}{x2}{x1} - являетя палиндромом");
    else Console.WriteLine($"{num} ->{x1}{x2}{x5}{x2}{x1} - не является палиндромом");
}