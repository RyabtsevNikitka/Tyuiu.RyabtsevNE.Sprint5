using System.IO;
using Tyuiu.RyabtsevNE.Sprint5.Task1.V27.Lib;

namespace Tyuiu.RyabtsevNE.Sprint5.Task1.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Ïîëüçîâàòåëè\1\source\repos\Tyuiu.FrankoVA.Sprint5\Tyuiu.FrankoVA.Sprint5\Tyuiu.FrankoVA.Sprint5.Task1.V27\bin\Debug\OutOutFileTask1.txt";
            string tempPath = Path.GetTempPath();


            string fileName = "OutOutFileTask0.txt";
            string p = Path.Combine(tempPath, fileName);

            FileInfo fileInfo = new FileInfo(path);


            bool fileExists = fileInfo.Exists;


            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
