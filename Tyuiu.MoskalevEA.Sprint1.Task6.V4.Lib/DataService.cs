using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.MoskalevEA.Sprint1.Task6.V4.Lib
{
    public class DataService : ISprint1Task6V4
    {
        public string CheckDoubleN(string value)
        {
            if (string.IsNullOrEmpty(value))
                return "";

            string[] words = value.Split(new char[] { ' ', ',', '.', '!', '?', ';', ':', '\t', '\n', '\r' },
                                       StringSplitOptions.RemoveEmptyEntries);

            string result = "";

            foreach (string word in words)
            {
                if (word.Contains("нн"))
                {
                    if (result != "")
                        result += " ";
                    result += word;
                }
            }
            return result;
        }
    }
}
