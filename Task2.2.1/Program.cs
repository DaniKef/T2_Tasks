// Гуренко Даниил
// Вариант 5
//Задание 2.2.1
//Дано натуральное число. Определить, все ли цифры в нем одинаковы.
using System;

namespace Task2._2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Задача 2.2.1-------");
            Console.WriteLine("Введите число: "); // ввод числа
            char[] theNumbersChar = Console.ReadLine().ToCharArray(); // принимает число в массив char
            int[] theNumbers = new int[theNumbersChar.Length]; // создает массив int длины массива theNumbersChar
            for (int i = 0; i < theNumbersChar.Length; i++) theNumbers[i] = theNumbersChar[i] - '0'; // копирует содержимое
            bool isSame = true; // для проверки одинаковые ли
            for (int i = 0; i < theNumbers.Length - 1; i++) // проходит по каждому числу в массиве
                if (theNumbers[i] != theNumbers[i + 1]) isSame = false; // проверяет текущее число с следующим, если они разные
                                                                        // ставится false и есть отличающиеся цифры в числе
            if (isSame) Console.WriteLine("Все цифры в числе одинаковые."); // если все числа одинаковые
            else Console.WriteLine("Есть разные цифры."); //  если есть разные
        }
    }
}
