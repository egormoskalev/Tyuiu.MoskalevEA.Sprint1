using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MoskalevEA.Sprint1.Task7.V23.Lib
{
    public class DataService : ISprint1Task7V23
    {
        public double Calculate(double x, double y)
        {
            double term1 = Math.Pow(10, Math.Sin(x));

            double term2 = (20 * Math.Pow(x, 2)) / (3 * Math.Pow(x, 3));

            double term3 = Math.Cos(Math.Pow(x, 2) - y);

            double result = x - term1 + term2 + term3;

            return Math.Round(result, 3);
        }
    }
}
