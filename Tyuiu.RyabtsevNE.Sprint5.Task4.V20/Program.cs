using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.RyabtsevNE.Sprint5.Task4.V20.Lib;

namespace Tyuiu.RyabtsevNE.Sprint5.Task4.V20
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");


            string path = @"C:\DataSprint5\InPutDataFileTask4V20.txt";


            Console.WriteLine("Данные находяться в файле: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Исходные данные:                                                        *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
