using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace CalculatorTest
{
    [TestClass]
    public class TestCalculator
    {
        [TestMethod]
        public void CanInstantiateCalculator()
        {
            SimpleCalculator calc = new SimpleCalculator();
        }

        [TestMethod]
        public void TextInvalidInput()
        {
            SimpleCalculator calc = new SimpleCalculator();
            try
            {
               
                int result = calc.Calculate("abcd");
                Assert.Fail();
            }
            catch(InvalidOperationException)
            {
                 
            }
        }
        void DoTest(string input,int expected)
        {
            SimpleCalculator calc = new SimpleCalculator();
            int result = calc.Calculate(input);
            Assert.AreEqual(expected, result);
        }
        [TestMethod]
        public void OneplusOne()
        {
           
           DoTest("1+1",2);
        }

        [TestMethod]
        public void TwominusOne()
        {
            DoTest("2-1",1);
        }

        [TestMethod]
        public void FivemultiplyTwo()
        {
            DoTest("5*2", 10);
        }

        [TestMethod]
        public void FourdividebyTwo()
        {
            DoTest("4/2", 2);
        }

    }
}
