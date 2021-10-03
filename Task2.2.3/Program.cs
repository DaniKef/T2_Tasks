// Гуренко Даниил
// Вариант 5
//Задание 2.2.3
//Дано натуральное число. Определить, является ли сумма его максимальной и минимальной цифр кратной числу а
using System;

namespace Task2._2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Задача 2.2.3-------");
            char[] theNumbersChar = Console.ReadLine().ToCharArray(); // принимает число в массив char
            int[] theNumbers = new int[theNumbersChar.Length]; // создает массив int длины массива theNumbersChar
            for (int i = 0; i < theNumbersChar.Length; i++) theNumbers[i] = theNumbersChar[i] - '0'; // копирует содержимое
            Console.Write("Какому числу кратно: "); // ввод числа, на кратность которого проверяется
            var multipleOf = Int32.Parse(Console.ReadLine()); //  число, кратность которому проверяется
            var sumOfMinAndMax = 0; //  сумма минимального и максимального цифр натурального числа
            if (theNumbers.Length == 1) sumOfMinAndMax = theNumbers[0]; // если размер массива == 1, то эта цифра и есть суммой мин. и макс.
            else
            {
                var minValue = theNumbers[0]; // присвоение минимального
                var maxValue = theNumbers[0]; // присвоение максимального
                for (int i = 0; i < theNumbers.Length; i++) // проходит по всем цифрам в массиве
                {
                    if (minValue > theNumbers[i]) minValue = theNumbers[i]; // проверяет значение и присваивает
                    if (maxValue < theNumbers[i]) maxValue = theNumbers[i];
                }
                sumOfMinAndMax = minValue + maxValue; // находит сумму мин. и макс. цифр
            }
            if ((sumOfMinAndMax % multipleOf) == 0) Console.WriteLine($"Сумма мин. и макс. чисел {sumOfMinAndMax} кратно числу {multipleOf}"); // проверяет кратность остатком от деления
            else Console.WriteLine($"Сумма мин. и макс. чисел {sumOfMinAndMax} НЕ кратно числу {multipleOf}"); // если не кратно
        }
    }
}
