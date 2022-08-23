// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] arr = new int[8]; //число  элементов массива
//через for:
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(-42, 43);
    Console.Write(arr[i] + ", ");
}
Console.WriteLine();