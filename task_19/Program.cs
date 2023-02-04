//  Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//
//                                                 14212 -> нет
//                                                 23432 -> да
//                                                 12821 -> да

Console.Clear();

Console.WriteLine("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine()!);
int num1 = num / 1000;
int num2 = num % 100;

if (num < 10000 || num >= 100000)

{
    Console.WriteLine($"Это не пятизначное число!");
}

else

{
    if ((num1 / 10 == num2 % 10) && (num1 % 10 % 10 == num2 / 10))

    {
        Console.WriteLine("Да, это число палиндром!");
    }

    else

    {
        Console.WriteLine("Нет, это число не палиндром!");
    }
}