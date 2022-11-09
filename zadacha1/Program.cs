// Task 66
// Задайте значения M и N. Напишите программу, которая найдет сумму натуральных элементов в промежутке от M до N.

// Запрашиваем у пользователя числа и преобразуем в формат integer
Console.Clear();
Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());

if (m < n) // Проверяем какое число меньше на случай, если второе число меньше первого - меняем их местами
    {
        int z = m;
        m = n;
        n = z;
    }

int Summa(int n, int m) // функция с рекурсией
{
    if (m == n) // Проверяем случай равенства двух чисел
        return n;
    else
    {
        int s = Summa(n, m-1) + m;
        return s;
    }
}

Console.Write("Сумма цифр в диапазоне между первым и вторым числом: ");
Console.WriteLine(Summa(n, m));