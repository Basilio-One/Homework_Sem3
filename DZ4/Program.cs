// Напишите программу, которая принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом. 
//Через строку нельзя решать само собой.

Console.WriteLine("Введите целое число");
try
{
    int num = Convert.ToInt32(Console.ReadLine());
    Polyandrom(num);
}
catch
{
    Console.WriteLine("Вводить нужно только целые числа");
}

void Polyandrom (int num) 
{   
    int newNum = (int) Math.Log(num, 10) + 1;
    int arg = newNum / 2;
    int rem = 0;
    while (arg > 0)
    {
        int div = num % 10;
        rem = rem + div * (int)Math.Pow(10, arg - 1);
        num = num / 10;
        arg--;
    }
    if(newNum%2!=0) num = num / 10;
    if(num==rem) Console.WriteLine("Является палиндромом");
    else Console.WriteLine("Не является палиндромом");
}