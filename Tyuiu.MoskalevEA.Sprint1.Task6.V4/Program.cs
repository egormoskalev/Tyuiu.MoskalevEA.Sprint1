using Tyuiu.MoskalevEA.Sprint1.Task6.V4.Lib;

namespace Tyuiu.MoskalevEA.Sprint1.Task6.V4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            string text;

            Console.WriteLine("Введите текст:");
            text = Console.ReadLine();

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            string result = ds.CheckDoubleN(text);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}