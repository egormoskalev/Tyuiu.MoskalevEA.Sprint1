using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MoskalevEA.Sprint1.Task3.V17.Lib
{
    public class DataService : ISprint1Task3V17
    {
        public bool ZeroCheck(double number)
        {

            double fractionalPart = Math.Abs(number - Math.Truncate(number));
            
            if (fractionalPart == 0)
                return false;
            
            int firstThreeDigits = (int)(fractionalPart * 1000);
            
            for (int i = 0; i < 3; i++)
            {
                int digit = firstThreeDigits % 10; 
                if (digit == 0)
                    return true;
                firstThreeDigits /= 10; 
            }
            return false;
        }
    }
}
    

