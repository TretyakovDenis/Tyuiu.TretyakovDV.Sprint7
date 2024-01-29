using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.TretyakovDV.Sprint7.Project.V7.Lib;

namespace Tyuiu.TretyakovDV.Sprint7.Project.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetBase()
        {
            DataService ds = new DataService();
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\TEST.csv";
            string[,] res = ds.GetBase(pathSaveFile);
            string[,] wait = { { "1", "2" }, { "3", "4" }, { "5", "6" } };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}