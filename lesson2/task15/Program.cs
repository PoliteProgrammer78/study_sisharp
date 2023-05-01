// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

string [] a_week = {"1 - Понедельник", "2 - Вторник", "3 - Среда", "4 - Четверг", "5 - Пятница", "6 - Суббота", "7 - Воскресенье"};

int i = 0;
while(i < a_week.Length)
{
    Console.WriteLine(a_week[i]);
	i++;
}

Console.Write("Выберите день недели числом: ");

int day = int.Parse(Console.ReadLine());

if (day <= 7)
{
    if (day <= 5)
    {
        Console.WriteLine("Рабочий день недели!");
    }

    else
    {
        Console.WriteLine("Выходной день недели!");
    }
}

else
{
    Console.WriteLine("Число " + day + " - несответствует дню недели!");
}