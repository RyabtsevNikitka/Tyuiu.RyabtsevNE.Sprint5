using Tyuiu.RyabtsevNE.Sprint5.Task4.V5.Lib;
namespace Tyuiu.RyabtsevNE.Sprint5.Task4.V5
{
    internal class Program
    {
        static void Main(string[] args)
        {


            DataService ds = new DataService();

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* Спринт #5                                                                *");
            Console.WriteLine("* Тема: Массивы                                                            *");
            Console.WriteLine("* Задание #4                                                               *");
            Console.WriteLine("* Вариант #5                                                               *");
            Console.WriteLine("* Выполнил: Рябцев Никита Евгеньевич | СМАРТб-24-1                         *");
            Console.WriteLine("****************************************************************************");

            Console.WriteLine("****************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         *");
            Console.WriteLine("****************************************************************************");

            string path = @"C:\Users\dlyav\source\repos\Tyuiu.RyabtsevNE.Sprint5\Tyuiu.RyabtsevNE.Sprint5.Task4.V5\bin\Debug\net8.0\InPutDataFileTask4V5.txt ";
            Console.WriteLine("Данные находятся в файле:  " + path);




            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);

            Console.WriteLine("Ответ: " + res);

            Console.ReadKey();
        }
    }
}
