// Гуренко Даниил
// Вариант 5
//Задача 1.1
//Написать программу, которая введет 6 значений и посчитает сумму чисел, больших 4 и меньших или равных 7.

using System;

namespace Task1._1
{
    class Program
    {
        static int GetRand(int x, int y) // метод для генерации числа 
        {
            var rand = new Random();
            var number = rand.Next(x, y); // от х до у
            return number;
        }
        static void PrintNumbers(int[] mas, int amount) // метод, чтоб печатать числа
        {
            Console.Write("Шесть значений: ");
            for (int i = 0; i < amount; i++)
                Console.Write(mas[i] + " ");
            Console.WriteLine();
        }
        static int CountSumOfNumbers(int[] mas, int amount) // метод, чтоб найти сумму
        {
            int sum = 0; // сумма чисел
            for (int i = 0; i < amount; i++)
                if (mas[i] > 4 && mas[i] <= 7) sum += mas[i]; // условие, по которому считается, если >4 и <=7
            return sum;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("-------Задача 1.1-------");
            var amountOfNum = 6; // 6 значений
            int[] theNumbers = new int[amountOfNum]; // создание массива из 6 чисел
            for (int i = 0; i < amountOfNum; i++) // заполнение массива
            {
                theNumbers[i] = GetRand(1, 10); // вызов метода для генерирования
                                                // случайного числа от 1 до 10
            }
            PrintNumbers(theNumbers, amountOfNum); // вызов метода, чтоб вывести эти 6 чисел
            var sumOfNumbers = CountSumOfNumbers(theNumbers, amountOfNum); // присвоение значению то, что вернется из метода
                                                                           // который считает сумму чисел от 4 до 7 включительно
            Console.WriteLine("Сумма шести чисел больших 4 и меньших или равных 7: " + sumOfNumbers); // вывести эту сумму 
        }
    }
}
