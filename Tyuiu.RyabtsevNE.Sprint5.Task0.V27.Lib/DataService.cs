﻿using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RyabtsevNE.Sprint5.Task0.V27.Lib
{
    public class DataService : ISprint5Task0V27
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask0.txt");
            double z = Math.Pow((x - 1), (3 * x + 1));
            z = Math.Round(z, 3);
            File.WriteAllText(path, Convert.ToString(z));
            return path;
        }
    }
}
