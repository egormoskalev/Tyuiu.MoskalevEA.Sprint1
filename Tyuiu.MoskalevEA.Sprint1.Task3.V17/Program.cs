using Tyuiu.MoskalevEA.Sprint1.Task3.V17.Lib;

namespace Tyuiu.MoskalevEA.Sprint1.Task3.V17
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
            x = (int)Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine(ds.ZeroCheck(x) ? "есть ноль" : "нет нуля");

            Console.ReadLine();
        }
    }
}

