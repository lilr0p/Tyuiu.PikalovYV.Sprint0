using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PikalovYV.Sprint0.Task2.V0.Lib; 
namespace Tyuiu.PikalovYV.Sprint0.Task.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "Юрий";
            var res = DataService.GetMessage(name);


            // Вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет..., Юрий", res);
        }
    }
}
