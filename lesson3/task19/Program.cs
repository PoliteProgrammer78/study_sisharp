// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/* 14212 -> нет

   12821 -> да

   23432 -> да */


Console.Write("Введите пятизначное число: ");

int number = int.Parse(Console.ReadLine());

/* int TheSecondDigit(int x)
{
    int resalt = x / 10;
    resalt = resalt % 10;
    return resalt;
} */