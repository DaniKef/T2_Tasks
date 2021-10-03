// Гуренко Даниил
// Вариант 5
// Задача 3.1.3
//Дан текст(строка), содержащий в себе группы  букв, цифр, символов. 
//Преобразовать текст, отсортировав каждую группу букв по алфавиту, каждую группу цифр в порядке убывания.
//Например: «cba1076 /’abfc3785,’’3946f»  - «abc7610 /’abcf8753,’’9643f» . Не использовать строковые функции
using System;

namespace Task3._1._3
{
    class Program
    {
        bool IsLetter(char a) // Метод, проверяющий, является ли передаваемое значение буквой
        {
            bool isLetter = false; // true - является буквой
            char[] alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray(); // массив английского алфавита
            for (int i = 0; i < alphabet.Length; i++) // сравнивает передаваемое значение со всеми буквами
            {
                if (a == alphabet[i]) isLetter = true; // если это одна из букв - возвращаемое значение true - является буквой 
            }
            return isLetter;
        }
        bool IsNumber(char a)// Метод, проверяющий, является ли передаваемое значение цифрой
        {
            bool isNumber = false;// true - является цифрой
            char[] numbers = "0123456789".ToCharArray(); // массив вохможных цифр
            for (int i = 0; i < numbers.Length; i++)// сравнивает передаваемое значение со всеми цифрами
            {
                if (a == numbers[i]) isNumber = true;// если это одна из цифр - возвращаемое значение true - является цифрой
            }
            return isNumber;
        }
        bool IsSymbol(char a)// Метод, проверяющий, является ли передаваемое значение символом, который разделяет строку
        {
            bool isSymbol = false;// true - является символом
            char[] symbols = "/\"'?.,!\\><=+-_:;~`@#№$%^&*()".ToCharArray();// массив вохможных символов
            for (int i = 0; i < symbols.Length; i++)// сравнивает передаваемое значение со всеми символами
            {
                if (a == symbols[i]) isSymbol = true;// если это один из символов - возвращаемое значение true - является символом
            }
            return isSymbol;
        }
        char[] StringSort(char[] a) // сортирует строку: буквы по алфавиту, цифры по убыванию
        {
            var n = a.Length; // значение длины массива символов строки
            for (var i = 0; i < n - 1; i++) // пузырьковая сортировка, сравнивает попарно
            {
                for (var j = 0; j < n - 1 - i; j++)
                {
                    if (IsNumber(a[j])) // для чисел сортирует в одну сторону
                    {////
                        if (IsSymbol(a[j + 1])) continue; // если это символ разделения - его пропустить
                        if (a[j + 1] > a[j]) // меняет местами в массиве
                        {
                            var t = a[j + 1];
                            a[j + 1] = a[j];
                            a[j] = t;
                        }
                    }////
                    else if (IsLetter(a[j])) // для букв сортирует в другую сторону
                    {////
                        if (IsSymbol(a[j + 1])) continue; // если это символ разделения - его пропустить
                        if (a[j + 1] < a[j]) // меняет местами в массиве
                        {
                            var t = a[j + 1];
                            a[j + 1] = a[j];
                            a[j] = t;
                        }
                    }////
                }
            }
            return a;
        }
        static void Main(string[] args)
        {
            var myProgram = new Program();
            Console.WriteLine("-------Задача 3.1.3-------");
            string myLetters = "bcaa12/''aj31b24/,w111abd7dd2"; // строка, которую надо отсортировать
            char[] myLettersChar = myLetters.ToCharArray(); // строку string в массив char
            char[] myNewLettersChar = new char[myLettersChar.Length]; // отсортированый массив
            myNewLettersChar = myProgram.StringSort(myLettersChar); //отсортированный массив, присваивается значение, которое 
                                                                    // возвращается с StringSort, куда передается изначльный массив
            Console.WriteLine(myNewLettersChar); // вывод нового массива
        }
    }
}
