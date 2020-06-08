using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            double a = 2, b = 6, c = 9;
            string actError, expError = "Нет действительных корней";
            double[] expResult = new double[0];
            double[] actResult = Class1.Result(a, b, c, out actError);
            Assert.AreEqual(expError, actError, "Полученное сообщение (" + actError + ") об ошибке не совпадает с ожиданием (" + expError + ")");
            Assert.AreEqual(expResult.Length, actResult.Length);
            for (int i = 0; i < expResult.Length; i++)
            {
                Assert.AreEqual(expResult[i], actResult[i]);
            }
        }
    }
}
