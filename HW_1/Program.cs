// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int VosvediStepen(int chislo, int stepen)
{
    int res = 1;
    for (int i = 1; i <= stepen; i++)
    {
        res = res * chislo;
    }
    return res;
}

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите требуемую степень: ");
int b = Convert.ToInt32(Console.ReadLine());

int res = 1;
if (b < 0) Console.Write("Прошу ввести неотрицательную степень: ");
else
{
    if (b == 0)
    {
        Console.WriteLine("Решение: " + res);
    }
    else
    {
        res = VosvediStepen(a, b);
        Console.WriteLine("Решение: " + res);
    }
}