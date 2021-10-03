// Гуренко Даниил
// Вариант 5
// Задача 3.2
//Уплотнить заданную матрицу, удаляя из нее строки и столбцы, заполненные нулями.
//Найти номер первой из строк, содержащих хотя бы один положительный элемент.
using System;

namespace Task3._2
{
    class Program
    {
        void PrintArray(int?[,] arr, int row, int col) // вывод двумерного массива
        {
            for(int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    Console.Write($"{arr[i, j]} \t");
                }
                Console.WriteLine();
            }
        }

        void CondenseArray(ref int?[,] arr, int row, int col, Program myProg)// уплотняет матрицу и находит первую строку 
        {                                               // с положительным элементом
            int?[] zeroRow = new int?[row]; // массив, индекс которого будет показывать какие все эдементы
                                            // начального массива в СТРОКЕ равны нулю
            for (int i = 0; i < zeroRow.Length; i++) // заполнение null
                zeroRow[i] = null;

            int?[] zeroCol = new int?[col]; // массив, индекс которого будет показывать какие все эдементы
                                            // начального массива в СТОЛБЦЕ равны нулю
            for (int i = 0; i < zeroCol.Length; i++)// заполнение null
                zeroCol[i] = null;

            for (int i = 0; i < row; i++) // находит строки, где одни нули
            {
                bool isNotZero = false; // ноль?
                for (int j = 0; j < col; j++)
                {
                    if (arr[i, j] != 0) isNotZero = true; // если есть ненулевые элементы true
                }
                if (!isNotZero) zeroRow[i] = i; // если значение не поменялось - в массив заносится
                                                // значение равное индекску Строки, где одни нули
            }

            for (int i = 0; i < col; i++)// находит столбцы, где одни нули
            {
                bool isNotZero = false;// ноль?
                for (int j = 0; j < row; j++)
                {
                    if (arr[j, i] != 0) isNotZero = true;// если есть ненулевые элементы true
                }
                if (!isNotZero) zeroCol[i] = i; // если значение не поменялось - в массив заносится
                                                // значение равное индекску Столбца, где одни нули
            }
            int? r = null; // переменная, которая будет получать индекс с массива строк, если значение не null
            int? c = null; // переменная, которая будет получать индекс с массива столбцов, если значение не null
            Console.WriteLine("-----Уплотненная матрица-----");
            bool isPosinive = false; // засекает первое положительное значение
            int firsrPositive = 0; // в какой по индексу строке
            for (int i = 0; i< row; i++) // проходит матрицу
            {
                if (!zeroRow[i].Equals(null)) r = (int)zeroRow.GetValue(i); // если значение не равно null - присваивает индекс строки с нулями
                for (int j = 0; j< col; j++)
                {
                    if (!zeroCol[j].Equals(null)) c = (int)zeroCol.GetValue(j); // если значение не равно null - присваивает индекс столбца с нулями
                    if (i == r || j == c)// если пришло время выводить массив индекс которого == индексу с нулями 
                    {                    // присвоить значение null и пропустить
                        arr[i, j] = null;
                        continue;
                    } 
                    if(arr[i,j] > 0) // первый положительный элемент
                    {
                        if(!isPosinive)
                        {
                            firsrPositive = i; // индекс строки положительного элемента
                            isPosinive = true; // больше не ищется
                        }
                    }
                }
            }
            Console.WriteLine();
            myProg.PrintArray(arr, row, col); // вывод массива
            Console.WriteLine("В первой из строк с индексом " + (firsrPositive )  + " содержится хотя бы один положительный элемент из старого массива.");
            // вывод индекса строки с первым положительным элементом
        }
        static void Main(string[] args)
        {
            var myProgram = new Program();
            Console.WriteLine("-------Задача 3.2-------");
            int?[,] originalArray = { // создание изначального массива
                { 0,-2,-6, 0,-3, 0,-1},
                { 0, -2, 3, 4, 5,6, 2},
                { 0, 0, 0, 0, 0, 0, 0},
                { 0, 0, 1, 0, 0, 0, 0}
            };
            int rows = originalArray.GetUpperBound(0) + 1; // строки
            int columns = originalArray.GetUpperBound(1) + 1; // столбцы
            myProgram.PrintArray(originalArray, rows, columns); // вывод матрицы
            myProgram.CondenseArray(ref originalArray, rows, columns, myProgram); // уплотняет матрицу и находит первую строку
                                                                   // с положительным элементом
        }
    }
}
