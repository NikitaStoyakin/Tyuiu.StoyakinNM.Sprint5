using System.Globalization;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.StoyakinNM.Sprint5.Task5.V13.Lib
{
    public class DataService : ISprint5Task5V13
    {
        public double LoadFromDataFile(string path)
        {
            double res = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] values = line.Split(' ');
                    foreach (string value in values)
                    {
                        if (double.TryParse(value, out double number))
                        {
                            if (number > -1.5 && number < 1.5)
                            {
                                res += number;
                            }
                        }
                    }
                }
            }
            double result = res / -2;
            return result;
        }
    }
}
