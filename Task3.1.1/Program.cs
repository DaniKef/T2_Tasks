// Гуренко Даниил
// Вариант 5
// Задача 3.1.1
//В массиве вещественных чисел все элементы, кроме первого, разделить на значение первого элемента
using System;

namespace Task3._1._1
{
    class Program
    {
        void FillMassDouble(ref double[] mas, Random rand) // метод генерации вещественных чисел
        {
            for (int i = 0; i < mas.Length; i++) // заполнение массива
            {
                mas[i] = rand.NextDouble() * 10; //генерирует вещественные числа от 0 до 10
            }
        }
        void PrintMass(double[] mas) // вывести массив
        {
            for (int i = 0; i < mas.Length; i++)
                Console.Write(mas[i] + " ");
            Console.WriteLine();
            Console.WriteLine("---------------------");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("-------Задача 3.1.1-------");
            var myProgram = new Program();
            var rand = new Random(); // класс рандом
            double[] theRealNumbers = new double[rand.Next(10, 15)]; // массив double размерностью от 10 до 15
            myProgram.FillMassDouble(ref theRealNumbers, rand);
            myProgram.PrintMass(theRealNumbers); // вывод массива
            for (int i = 1; i < theRealNumbers.Length; i++) // делит все на 1 элемент, кроме первого
            {
                theRealNumbers[i] = theRealNumbers[i] / theRealNumbers[0];
            }
            myProgram.PrintMass(theRealNumbers); // вывод массива
        }
    }
}
