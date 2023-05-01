// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите трехзначное число: ");

int n = int.Parse(Console.ReadLine());


if (n <= 999)
{
    if (n >= 100)
    {
        int resalt = n % 10;
        Console.WriteLine("Третья цифра " + resalt);
    }
    else
    {
        Console.WriteLine("Не трехзначное число!");
    }
}
else
    {
        Console.WriteLine("Не трехзначное число!");
    }

