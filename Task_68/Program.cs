#pragma warning disable 
Console.Clear(); 
Console.WriteLine("Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");

Console.Write("Введите не отрицательное число M: "); 
int m; 
int.TryParse(Console.ReadLine()!, out m); 
Console.Write("Введите не отрицательное число N: "); 
int n; 
int.TryParse(Console.ReadLine()!, out n);

if (n < 1 ||  m < 1)
{
    Console.WriteLine("Ввели ОТРИЦАТЕЛЬНОЕ числоэ!!");
}

Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}