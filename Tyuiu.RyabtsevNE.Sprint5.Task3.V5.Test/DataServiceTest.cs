using Tyuiu.RyabtsevNE.Sprint5.Task3.V5.Lib;

namespace Tyuiu.RyabtsevNE.Sprint5.Task3.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\dlyav\source\repos\Tyuiu.RyabtsevNE.Sprint5\Tyuiu.RyabtsevNE.Sprint5.Task2.V1\bin\Debug\net8.0\OutPutFileTask3.bin";
            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
