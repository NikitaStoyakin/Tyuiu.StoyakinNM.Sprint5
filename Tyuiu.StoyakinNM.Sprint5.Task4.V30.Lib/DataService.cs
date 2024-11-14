﻿using System.Globalization;
using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;
namespace Tyuiu.StoyakinNM.Sprint5.Task4.V30.Lib
{
    public class DataService : ISprint5Task4V30
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            double x = Convert.ToDouble(strX, CultureInfo.InvariantCulture);
            double res = Math.Round((Math.Pow(x, 3) - Math.Tan(x)) + 2.03 * x, 3);
            return res;
        }
    }
}
