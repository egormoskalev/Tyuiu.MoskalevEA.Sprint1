using Tyuiu.MoskalevEA.Sprint1.Task2.V3.Lib;

namespace Tyuiu.MoskalevEA.Sprint1.Task2.V3
{
  
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int x;

            Console.WriteLine("Введите время в часах");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Время в минутах = " + ds.ConvertHourToMin(x));

            Console.ReadLine();
        }
    }
}
