#pragma warning disable 
Console.Clear(); 
Console.WriteLine("Задача 64:Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии."); 

Console.Write("Введите НАТУРАЛЬНОЕ значение числа N: "); 
int n; 
int.TryParse(Console.ReadLine()!, out n); 
int m = 1; 

if (n < 1)
{
    Console.WriteLine("Ввели не НАТУРАЛЬНОЕ число");
}

int Number(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{Number(n, m + 1)}, ");
    return m;
}

Console.WriteLine(Number(n, m));
