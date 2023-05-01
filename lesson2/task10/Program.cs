// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int random = new Random().Next(100, 1000);
Console.WriteLine("Рандомное число: " + random);

Console.WriteLine("Вторая цифра " + TheSecondDigit(random));

int TheSecondDigit(int x)
{
    int resalt = x / 10;
    resalt = resalt % 10;
    return resalt;
}