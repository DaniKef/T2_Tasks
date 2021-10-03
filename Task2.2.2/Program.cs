// Гуренко Даниил
// Вариант 5
//Задание 2.2.2
//Дано натуральное число. Определить сумму его первой и последней цифр.
using System;

namespace Task2._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Задача 2.2.2-------");
            char[] theNumbersChar = Console.ReadLine().ToCharArray(); // принимает число в массив char
            int[] theNumbers = new int[theNumbersChar.Length]; // создает массив int длины массива theNumbersChar
            for (int i = 0; i < theNumbersChar.Length; i++) theNumbers[i] = theNumbersChar[i] - '0'; // копирует содержимое
            var sumOfTwoNumbers = 0; // сумма первой и последней цифр
            if (theNumbers.Length == 1) sumOfTwoNumbers = theNumbers[0]; // если введено только 1 цифра = это и есть сумма
            else sumOfTwoNumbers = theNumbers[0] + theNumbers[theNumbers.Length - 1]; // нахождение числа первой и последних чисел
            Console.WriteLine($"Сумма первой и последней цифр числа : {sumOfTwoNumbers}"); // вывод результата
        }
    }
}
