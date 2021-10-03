// Гуренко Даниил
// Вариант 5
//Задание 2.1
//В учебном заведении задается начало учебного дня, продолжительность урока, 
//длительность обычной и большой перемены (и место большого перерыва в расписании), 
//количество уроков.Вывести расписание звонков на весь учебный день(часы, минуты).
using System;

namespace Task2._1
{
    class Program
    {
        struct WorkingDay // Структура с нужными переменными и методами рабочего дня 
        {
            public string beginOfDay; // начало дня
            public int beginOfDayHour; // начало дня(часы)
            public int beginOfDayMinute; // начало дня(минуты)
            public int lessonDuration; // длительность урока
            public int usualBreak; // обычный перерыв
            public int bigBreak; // большой перерыв
            public int whereBigBreak; // после какого урока большой перерыв
            public int numberOfLessons; // сколько уроков 
            public void ConverStringDayToInt() // разбить для счета минуты и часы beginOfDay, которые ввел человек
            {
                string[] words = beginOfDay.Split(new char[] { ':' });
                this.beginOfDayHour = Int32.Parse(words[0]); // сюда час (число до :)
                this.beginOfDayMinute = Int32.Parse(words[1]);// сюда минуту (число после :)
            }
            public void GetSchedule() // Получить расписание предметов
            {
                String[] word = { "Первый", "Второй", "Третий", "Четвертый",
                    "Пятый", "Шестой", "Седьмой", "Восьмой" }; // для удобства уроки
                int t1 = this.beginOfDayHour; // временная переменна часа
                int t2 = this.beginOfDayMinute; // временная переменная минуты
                for (int i = 0; i < this.numberOfLessons; i++) // проходит с 1 до последнего урока
                {
                    Console.WriteLine(word[i] + " урок."); // урок
                    Console.WriteLine("Начало: " + t1 + ":" + t2); // начало урока
                    t2 += this.lessonDuration; // к минутам + длительность урока
                    if (t2 >= 60) // если минут > 60 - начался новый час
                    {
                        t2 -= 60; // -60 минут
                        t1 += 1; // +1 час
                    }
                    Console.WriteLine("Конец: " + t1 + ":" + t2); // конец урока
                    if ((i + 1) == this.whereBigBreak) t2 += this.bigBreak; // если время для большой перемены + время большой перемены
                    else t2 += this.usualBreak; // всегда добавляет время обычной перемены
                    if (t2 >= 60) // еще раз проверка, чтоб переносить минуты и часы
                    {
                        t2 -= 60;
                        t1 += 1;
                    }
                }
            }
        }
        static void SetWorkingDayValues(ref WorkingDay thisDay) // Чтоб пользователь присвоил значения 
        {
            Console.Write("Задать начало учебного дня (Задавать так: 9:40): ");
            thisDay.beginOfDay = Console.ReadLine();
            thisDay.ConverStringDayToInt();// вызов метода, чтоб разделить минуты и часы
            Console.Write("Задать продолжительность урока: ");
            thisDay.lessonDuration = Int32.Parse(Console.ReadLine());
            Console.Write("Задать длительность обычной перемены: ");
            thisDay.usualBreak = Int32.Parse(Console.ReadLine());
            Console.Write("Задать длительность большой перемены: ");
            thisDay.bigBreak = Int32.Parse(Console.ReadLine());
            Console.Write("Задать место большой перемены (после какого урока): ");
            thisDay.whereBigBreak = Int32.Parse(Console.ReadLine());
            Console.Write("Сколько уроков: ");
            thisDay.numberOfLessons = Int32.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Console.WriteLine("-------Задача 2.1-------");
            var thisDay = new WorkingDay(); // создание структуры
            SetWorkingDayValues(ref thisDay); // Установка значений, передается ссылка
            if (thisDay.whereBigBreak >= thisDay.numberOfLessons || thisDay.numberOfLessons >= 8)// если большая перемена после последнего урока или позже.
                                                                                                 // если количество уроков слишком большое
            {
                Console.WriteLine("Введите данные нормально");
                System.Environment.Exit(0); // выход из программы
            }
            thisDay.GetSchedule(); // вызов метода получить расписание
        }
    }
}
