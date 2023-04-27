// Задача 8

Console.Write("Введите число ");
int n = int.Parse(Console.ReadLine());


Random rnd = new Random(DateTime.Now.Millisecond);
for (int i = 1; i <= n; i++)
{
    if(i % 2 == 0)
    {
        Console.WriteLine(i);
    }
}