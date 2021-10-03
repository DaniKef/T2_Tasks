// Гуренко Даниил
// Вариант 5
// Задача 3.1.2
//Найти количество различных элементов массива.
using System;

namespace Task3._1._2
{
    class Program
    {
        void FillMassInt(ref int[] mas, Random rand) // метод генерации чисел int
        {
            for (int i = 0; i < mas.Length; i++) // заполнение массива
            {
                mas[i] = rand.Next(1, 10); //генерирует числа от 1 до 10
            }
        }
        void PrintMass(int[] mas) // вывести массив
        {
            for (int i = 0; i < mas.Length; i++)
                Console.Write(mas[i] + " ");
            Console.WriteLine();
            Console.WriteLine("---------------------");
        }
        int DistinctNumbers(int[] beginArray) // метод, считающий количество различных элементов массива
        {
            bool isContained = false; // переменная, содержится похожий элемент = true
            int count = 0; // счетчик различных элементов
            for (int i = 0; i < beginArray.Length; i++) // сравнение 1 элемента с массива
            {
                for (int j = 0; j < beginArray.Length; j++) // с остальными
                {
                    if (i == j) continue; // если индексы равны - пропустить итерацию
                    if (beginArray[i] == beginArray[j]) isContained = true; // если нашлись похожие элементы - isContained(содержится) = true
                }
                if (isContained == false) count++; // после сравнения всех элементов, если переменной не содержится, увелич. счетчик
                isContained = false; // установка опять в false как и в начале
            }
            return count; // возвращает счетчик
        }
        static void Main(string[] args)
        {
            Console.WriteLine("-------Задача 3.1.2-------");
            var myProgram = new Program();
            var rand = new Random(); // класс рандом
            var arrayOfNumbers = new int[rand.Next(6, 10)];// массив int размерностью от 6 до 10
            myProgram.FillMassInt(ref arrayOfNumbers, rand); // заполнение массива
            myProgram.PrintMass(arrayOfNumbers); // вывод массива
            int count = myProgram.DistinctNumbers(arrayOfNumbers); // метод, считающий количество различных элементов массива
            Console.WriteLine("Количество различных элементов массива: " + count); // вывод count
        }
    }
}
