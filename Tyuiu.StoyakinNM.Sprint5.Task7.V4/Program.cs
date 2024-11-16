using Tyuiu.StoyakinNM.Sprint5.Task7.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил: Стоякин Н.М. | ПКТб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Добавление к решению итоговых проектов по спринту                 *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #4                                                              *");
        Console.WriteLine("* Выполнил: Стоякин Никита Михайлович | ПКТб 24-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан файл С:\\DataSprint5\\InPutDataFileTask7V4.txt. Заменить все          *");
        Console.WriteLine("* русские буквы на #.Полученный результат сохранить в файл                *");
        Console.WriteLine("* OutPutDataFileTask7V4.txt.                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        string path = Path.Combine(Path.GetTempPath(), "InPutDataFileTask7V4.txt");
        string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutFileTask7V4.txt");

        Console.WriteLine(" Данные находятся в файле: " + path);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Находится в файле: ");
        pathSaveFile = ds.LoadDataAndSave(path);

        Console.WriteLine(pathSaveFile);
        Console.ReadKey();
    }
}