using Tyuiu.StoyakinNM.Sprint5.Task1.V29.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        int startValue = -5;
        int stopValue = 5;
        DataService ds = new DataService();
        Console.Title = "Спринт #5 | Выполнил: Стоякин Н.М. | ПКТб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #5                                                               *");
        Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #29                                                             *");
        Console.WriteLine("* Выполнил: Стоякин Никита Михайлович | ПКТб 24-1                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дана функция, f(x) на заданном диапазоне [-5; 5] с шагом 1. Произвести  *");
        Console.WriteLine("* проверку деления на ноль. При делении на ноль вернуть значение 0.       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("StartValue = " + startValue);
        Console.WriteLine("StartValue = " + stopValue);

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ;                                                              *");
        Console.WriteLine("***************************************************************************");

        string res = ds.SaveToFileTextData(startValue, stopValue);

        Console.WriteLine("Файл " + res);
        Console.WriteLine("Создан!");
        Console.ReadKey();
    }
}