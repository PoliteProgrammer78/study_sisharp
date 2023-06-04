// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да


int number = Prompt("Введите число: ");
int numberMirr = FindMirrorNumber(number);
FindPalindron(number, numberMirr);

int Prompt(string message)
{
    Console.Write(message);
    int mess = int.Parse(Console.ReadLine()!);
    return mess;
}

int FindMirrorNumber(int x)
{
    int result = 0;
    while (x > 0)
    {
        result = result * 10 + x % 10;
        x /= 10;
    }
    return result;
}

void FindPalindron(int a, int b)
{
    Console.WriteLine(number);
    Console.WriteLine(numberMirr);
    if (number == numberMirr)
    {
        Console.Write("YES");
    }
    else
    {
        Console.Write("NO");
    }
}
