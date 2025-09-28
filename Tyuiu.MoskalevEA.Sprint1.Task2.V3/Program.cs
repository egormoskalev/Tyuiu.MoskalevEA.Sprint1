using Tyuiu.MoskalevEA.Sprint1.Task2.V3.Lib;

namespace Tyuiu.MoskalevEA.Sprint1.Task2.V3
{
    class Programm
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int x;

            Console.WriteLine("Введите значение X:");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine(ds.ConvertHourToMin(x));
           
            Console.ReadLine();
        }
    }
}

