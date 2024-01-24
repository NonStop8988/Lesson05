// Задача 1. Вычислить факториал от натурального числа N (N!).

int Fact(int n)
{
    if (n == 1 || n == 0)
    {
        Console.WriteLine($"Stop requrson: {n}");
        return 1;
    }
    Console.WriteLine(n);
    // Console.WriteLine($"Возврат: n = [{n}], fact = {Fact(n - 1)}");
    int result = n * Fact(n - 1);
    return result;
}

// Console.Clear();
int number = 5;
Console.WriteLine($"Факториал числа {number} = {Fact(number)}");














// using System;

// class Program
// {
//     static void Main()
//     {
//         int number = 5;
//         Console.WriteLine($"Факториал {number} = {Factorial(number)}");
//     }

//     static int Factorial(int n)
//     {
//         Console.WriteLine($"Вызов функции Factorial({n})");

//         // Базовый случай: факториал 0 или 1 равен 1
//         if (n == 0 || n == 1)
//         {
//             Console.WriteLine($"Базовый случай: Factorial({n}) = 1");
//             return 1;
//         }

//         // Рекурсивный случай: n! = n * (n-1)!
//         int result = n * Factorial(n - 1);

//         // Вывод результата перед возвратом
//         Console.WriteLine($"Factorial({n}) = {result}");

//         return result;
//     }
// }
