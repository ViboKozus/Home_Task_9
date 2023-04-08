#pragma warning disable 
Console.Clear(); 
Console.WriteLine("Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N."); 

Console.Write("Введите НАТУРАЛЬНОЕ значение числа M: "); 
int m; 
int.TryParse(Console.ReadLine()!, out m); 
Console.Write("Введите НАТУРАЛЬНОЕ значение числа N: "); 
int n; 
int.TryParse(Console.ReadLine()!, out n);

if (n < 1 ||  m < 1)
{
    Console.WriteLine("Ввели не НАТУРАЛЬНОЕ число");
}

int SUM(int m, int n)
{
    if (m == n)
    return m;
    else if (m > n)
    return 0;
    return m + SUM(m + 1, n);
}
Console.Write($"Сумма натуральных элементов от {m} до {n} = {SUM(m, n)} ");