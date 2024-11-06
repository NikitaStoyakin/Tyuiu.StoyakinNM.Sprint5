using Tyuiu.StoyakinNM.Sprint5.Task0.V13.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int x = 5;
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил: Стоякин Н.М. | ПКТб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись данных в текстовый файл                        *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #13                                                             *");
        Console.WriteLine("* Выполнил: Стоякин Никита Михайлович | ПКТб 24-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дано выражение , вычислить его значение при x = 5, результат сохранить  *");
        Console.WriteLine("* в текстовый файл OutPutFileTask0.txt и вывести на консоль. Округлить    *");
        Console.WriteLine("* до трёх знаков после запятой.                                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("x = " + x);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ;                                                              *");
        Console.WriteLine("***************************************************************************");

        string res = ds.SaveToFileTextData(x);

        Console.WriteLine("Файл " + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();
    }
}