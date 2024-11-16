using System.Runtime.CompilerServices;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.Text;
namespace Tyuiu.StoyakinNM.Sprint5.Task7.V4.Lib
{
    public class DataService : ISprint5Task7V4
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutFileTask7V4.txt");

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if(fileExists)
            {
                File.Delete(pathSaveFile);
            }

            string inputData = File.ReadAllText(path);

            string processedData = System.Text.RegularExpressions.Regex.Replace(inputData, "[а-яА-ЯёЁ]", "#");

            File.WriteAllText(pathSaveFile, processedData);

            return pathSaveFile;
        }
    }
}
