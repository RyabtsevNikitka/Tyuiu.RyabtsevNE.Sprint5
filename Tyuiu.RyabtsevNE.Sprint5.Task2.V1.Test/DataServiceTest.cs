﻿using System.IO;
using Tyuiu.RyabtsevNE.Sprint5.Task2.V1.Lib;

namespace Tyuiu.RyabtsevNE.Sprint5.Task2.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\dlyav\source\repos\Tyuiu.RyabtsevNE.Sprint5\Tyuiu.RyabtsevNE.Sprint5.Task2.V1\bin\Debug\net8.0\OutPutFileTask1.txt"; ;

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}