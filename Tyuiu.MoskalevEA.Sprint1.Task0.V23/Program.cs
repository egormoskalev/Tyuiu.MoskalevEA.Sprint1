using Tyuiu.MoskalevEA.Sprint1.Task0.V23.Lib;

namespace Tyuiu.MoskalevEA.Sprint1.Task0.V23
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
            Console.WriteLine("* Задание #0                                                             *");
            Console.WriteLine("* Вариант #23                                                            *");
            Console.WriteLine("* Выполнил:Москалев Егор Александрович. | ИСПб-25-1                      *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая вычисляет выражение (15/5*4)+1             *");
            Console.WriteLine("* и печатает результат на экране.                                        *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine(ds.Calculate());

            Console.ReadLine();
        }
    }
}