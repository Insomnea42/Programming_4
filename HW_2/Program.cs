// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
n = Math.Abs(n);
int numb = 0, res = 0;
if (n < 10) Console.WriteLine("Результат: " + n);
else
{
    while (n >= 10 | n % 10 != 0)
    {
        numb = n % 10;
        res = res + numb;
        n = n / 10;
    }
    Console.WriteLine("Результат: " + res);
}

