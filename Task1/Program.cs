// Задача 1. Вычислить факториал от натурального числа N (N!).

int Fact(int n)
{
    if (n == 1 || n == 0)
    {
        Console.WriteLine($"Значение параметра n при вызове рекурсии = {n}. СТОП! Выполнена цель вызова рекусрии - достигнут базовый случай (задача стала тривиальной)");
        return 1;
    }
    Console.WriteLine($"Значение параметра n при вызове рекурсии = {n}");
    int result = n * Fact(n - 1);
    Console.WriteLine($"Раскручивание рекусрии - возврат: n = [{n}], значение fact при данном параметре = {result / n}");
    return result;
}

Console.Clear();
int number = 5;
Console.WriteLine($"Факториал числа {number} = {Fact(number)}");
