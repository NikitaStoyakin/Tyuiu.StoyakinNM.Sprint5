using System.Text.RegularExpressions;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.StoyakinNM.Sprint5.Task6.V16.Lib
{
    public class DataService : ISprint5Task6V16
    {
        public int LoadFromDataFile(string path)
        {
            int count = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                string pattern = @"\b[a-zA-Z]+\b";
                while ((line = reader.ReadLine()) != null)
                {
                    MatchCollection matches = Regex.Matches(line, pattern);
                    count += matches.Count;
                }
            }
            return count;
        }
    }
}
