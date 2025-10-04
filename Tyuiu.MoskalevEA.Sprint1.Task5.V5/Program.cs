using Tyuiu.MoskalevEA.Sprint1.Task5.V5.Lib;

namespace Tyuiu.MoskalevEA.Sprint1.Task5.V5;

class Programm
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *"); ;
        Console.WriteLine("**************************************************************************");

        double x;

        Console.WriteLine("Введите значение X:");
        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("**************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("**************************************************************************");

        int result = ds.Calculate(x);

        Console.WriteLine(ds.Calculate(x));

        Console.ReadLine();
    }
}