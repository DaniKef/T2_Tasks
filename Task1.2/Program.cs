// Гуренко Даниил
// Вариант 5
//Задача 1.2
//Найти сумму 1^2+ 2^2+ 3^2+... + 10^2.
//Операцию возведения в степень не использовать, 
//учесть особенности получения квадрата натурального числа, отмеченные в предыдущей задаче.
using System;

namespace Task1._2
{
    class Program
    {
        static int CountSqrt(int end) // Считает квадрат заданного числа 
        {
            var sqrt = 0; // переменная квадрата
            var begin = 1; // сумма начинается с 1
            while (begin <= end)
            {
                sqrt += ((2 * begin) - 1); // 1+3+5+... + 2n-1
                begin++; // переход на следующее число
            }
            return sqrt;
        }
        static int CountSumOfSqrt(int begin, int end) // Считает сумму квадратов от числа begin до end 
        {
            int _sum = 0; // сумма
            for (int i = begin; i <= end; i++)
            {
                _sum += CountSqrt(i); // добавляет к сумме квадрат числа, которое указывается в методе
            }
            return _sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("-------Задача 1.2-------");
            var sum = CountSumOfSqrt(1, 10); // sum равен возвращаемому значению метода, от 1 до 10
            Console.WriteLine($"Сумма квадратов от 1 до 10: {sum}"); // вывод суммы
        }
    }
}
