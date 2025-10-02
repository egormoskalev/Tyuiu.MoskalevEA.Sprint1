using Tyuiu.MoskalevEA.Sprint1.Task2.V3.Lib;

namespace Tyuiu.MoskalevEA.Sprint1.Task2.V3
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Москалев Е. А. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #                                                               *");
            Console.WriteLine("* Тема: Создания итогового решения по спринту                            *");
            Console.WriteLine("* Задание #2                                                             *");
            Console.WriteLine("* Вариант #3                                                             *");
            Console.WriteLine("* Выполнил:Москалев Егор Александрович. | ИСПб-25-1                      *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные,*");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.            *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("*Формулировка задания: Задано количество часов. Перевести время в минуты.*");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("*Что пользователь вводит ? Время в часах(целое число)                    *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("*Что программа печатает на экране? Время в минутах (целое число)         *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            double x;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Минут в часах" + ds.ConvertHourToMin((int)x));
           
            Console.ReadLine();
        }
    }
}

