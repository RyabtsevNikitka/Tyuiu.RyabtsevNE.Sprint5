namespace Tyuiu.RyabtsevNE.Sprint5.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\dlyav\source\repos\Tyuiu.RyabtsevNE.Sprint5\Tyuiu.RyabtsevNE.Sprint5.Task5.V5\bin\Debug\net8.0\InPutDataFileTask5V5.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
