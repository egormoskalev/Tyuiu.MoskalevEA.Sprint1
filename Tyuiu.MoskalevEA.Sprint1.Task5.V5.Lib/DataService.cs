using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MoskalevEA.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            if (x <= 0)
            {
            
            }
            string numberString = x.ToString(System.Globalization.CultureInfo.InvariantCulture);

            int decimalPointIndex = numberString.IndexOf('.');

            if (decimalPointIndex == -1 || decimalPointIndex == numberString.Length - 1)
            {
                return 0;
            }

            char firstDecimalChar = numberString[decimalPointIndex + 1];

            if (char.IsDigit(firstDecimalChar))
            {
                return int.Parse(firstDecimalChar.ToString());
            }

            return 0;
        }
    }
}
    

