using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.StoyakinNM.Sprint5.Task0.V13.Lib
{
    public class DataService : ISprint5Task0V13
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";
            x = 5;
            double z = -1.4 * Math.Pow(x, 3) + 2.3 * Math.Pow(x, 2) + 0.6 * x;
            z = Math.Round(z, 3);
            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}
